﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Blog.Core.Models;

namespace Blog.DataAccess
{
    /// <summary>
    /// Initializer block of our Blog
    /// </summary>
    public class BlogInitializer : System.Data.Entity.DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            base.Seed(context);
            var tags = new List<Tag>
            {
                new Tag
                {
                    Name = "tag1"
                },
                new Tag
                {
                    Name = "tag2"
                }
            };
            //tags.ForEach(s=>context.Tags.Add(s));
            //context.SaveChanges();
            // create temp value for add init data for our project
            var articles = new List<Article>
            {
                new Article
                {
                    Name = "Article 1",
                    Date =  DateTime.Parse("2019-09-19").ToShortDateString(),
                    Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Autem voluptate aspernatur incidunt maxime beatae deleniti exercitationem repellat, adipisci tempora repellendus doloremque ratione, laboriosam hic dolores ipsa asperiores illo reiciendis similique ut, eos itaque quasi tempore excepturi? Magnam esse voluptatibus dolor.",
                    Tags = tags.ToList()
                },
                new Article
                {
                    Name = "Article 2",
                    Date = DateTime.Parse("2019-09-19").ToShortDateString(),
                    Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Autem voluptate aspernatur incidunt maxime beatae deleniti exercitationem repellat, adipisci tempora repellendus doloremque ratione, laboriosam hic dolores ipsa asperiores illo reiciendis similique ut, eos itaque quasi tempore excepturi? Magnam esse voluptatibus dolor.",
                    Tags = tags.ToList()
                },
                new Article
                {
                    Name = "Article 3",
                    Date = DateTime.Parse("2019-09-19").ToShortDateString(),
                    Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Autem voluptate aspernatur incidunt maxime beatae deleniti exercitationem repellat, adipisci tempora repellendus doloremque ratione, laboriosam hic dolores ipsa asperiores illo reiciendis similique ut, eos itaque quasi tempore excepturi? Magnam esse voluptatibus dolor.",
                    Tags = tags.ToList()
                },
                new Article
                {
                    Name = "Article 4",
                    Date = DateTime.Parse("2019-09-19").ToShortDateString(),
                    Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Autem voluptate aspernatur incidunt maxime beatae deleniti exercitationem repellat, adipisci tempora repellendus doloremque ratione, laboriosam hic dolores ipsa asperiores illo reiciendis similique ut, eos itaque quasi tempore excepturi? Magnam esse voluptatibus dolor.",
                    Tags = new List<Tag>{ new Tag { Name = "TAG3"} }
                }
            };
            // and add entity
            articles.ForEach(s => context.Articles.Add(s));//.Tags.AddRange(tags));
            context.SaveChanges();


            var feedbackItems = new List<FeedBack>
            {
                new FeedBack
                {
                    Name = "Author 1",
                    Date = DateTime.Parse("2019-09-19").ToShortDateString(),
                    Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Velit in animi, quisquam vel non placeat minus numquam accusamus voluptatibus atque."
                },
                new FeedBack
                {
                    Name = "Author 2",
                    Date = DateTime.Parse("2019-09-19").ToShortDateString(),
                    Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Velit in animi, quisquam vel non placeat minus numquam accusamus voluptatibus atque."
                },
                new FeedBack
                {
                    Name = "Author 3",
                    Date = DateTime.Parse("2019-09-19").ToShortDateString(),
                    Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Velit in animi, quisquam vel non placeat minus numquam accusamus voluptatibus atque."
                },
                new FeedBack
                {
                    Name = "Author 4",
                    Date = DateTime.Parse("2019-09-19").ToShortDateString(),
                    Text = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Velit in animi, quisquam vel non placeat minus numquam accusamus voluptatibus atque."
                },
            };
            feedbackItems.ForEach(s => context.FeedbackItems.Add(s));
            context.SaveChanges();

            Profile profile = new Profile
            {
                ProfilePreview = "На сколько вы человек?",

                Questions = new List<Question>
                {
                    new Question
                    {
                        Text = "Ты человек?"
                    },
                    new Question
                    {
                        Text = "Ты мужчина?"
                    },
                    new Question
                    {
                        Text = "Ты женщина?"
                    }
                }

            };

            var poll = new Poll
            {
                Active = false,
                Question = "How you doing?",
                PollOptionses = new List<PollOptions>
                {
                    new PollOptions
                    {
                            Answer = "Ok",
                            Votes = 100
                    },
                    new PollOptions
                    {
                            Answer = "ne ok",
                            Votes = 200
                    }
                }
            };

            context.Profiles.Add(profile);
            context.SaveChanges();
            context.Polls.Add(poll);
            context.SaveChanges();
        }
    }
}