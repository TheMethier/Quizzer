using System;
using System.Data;
using System.Runtime.CompilerServices;
using TriviaApp.Dto;
using TriviaAppSerices.Entities;
using TriviaAppSerices.Models;
[assembly:
InternalsVisibleTo("WinFormsApp1")]
namespace TriviaApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Dictionary<int, string> topics = new Dictionary<int, string>
            {
                { 9, "General Knowledge" },
                { 10, "Books" },
                { 11, "Film" },
                {12, "Music" },
                {17, "Science and Nature" },
                {18, "Computers" },
                {19, "Mathematics" },
                {22, "Geography" }
            };
            List<string> difficulties = new List<string>()
            {
                "easy",
                "medium",
                "hard"
            };
            List<int> numbers = new List<int>() { 
                10,20,30,40,50
            };
            TriviaAPIListener listener = new TriviaAPIListener();
            DataContext dataContext = new DataContext();
            if (dataContext.Answers.Count()==0)
            {            
                foreach (var topic in topics)
                {
                    Category category = new Category(topic.Value);
                    await dataContext.Categories.AddAsync(category);
                    await dataContext.SaveChangesAsync();
                    foreach (var difficulty in difficulties)
                    {
                        foreach (var number in numbers)
                        {
                            Response response = await listener.GetData(new TriviaRequest(number, topic.Key, difficulty));
                            Deck deck = new Deck(category.Id, number, difficulty, category);
                            await dataContext.Decks.AddAsync(deck);
                            response.Questions.ForEach(async x =>
                            {
                                Question question = new Question(x.ContentOfQuestion, number, deck);
                                List<Answer> answers = x.IncorrectAnswers.Select(y => new Answer(y, false, question))
                                .ToList();
                                Answer answer = new Answer(1, x.CorrectAnswer, true, question);
                                answers.Add(answer);
                                answers = answers.OrderBy(x => Random.Shared.Next())
                                .ToList();
                                await dataContext.Questions.AddAsync(question);
                                await dataContext.Answers.AddRangeAsync(answers);
                            });
                            await Console.Out.WriteLineAsync("Added "+ number+" questions "+" from "+ topic + "with difficulty: " + difficulty);
                            await Task.Delay(6000);
                        }
                    }
                }
            }   
        }
    }
}