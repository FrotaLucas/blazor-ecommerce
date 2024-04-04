﻿namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        //PQ TEM QUE SER PROTECTED OVERRIDE AQUI?????
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movie",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
            );

            modelBuilder.Entity<Product>().HasData(

                 new Product
                 {
                     Id = 1,
                     Title = "The Hitchhiker's Guide to the Galaxy",
                     Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                     Price = 7.99m,
                     CategoryId = 1

                 },
                  new Product
                  {
                      Id = 2,
                      Title = "Red Player One",
                      Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                      Price = 9.99m,
                      CategoryId = 1
                  },
                  new Product
                  {
                      Id = 3,
                      Title = "Nineteen Eitghy-Four",
                      Description = "Nineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance, and repressive regimentation of people and behaviours within society.[3][4] Orwell, a democratic socialist, modelled the authoritarian state in the novel on the Soviet Union in the era of Stalinism and Nazi Germany.[5] More broadly, the novel examines the role of truth and facts within societies and the ways in which they can be manipulated.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/51/1984_first_edition_cover.jpg",
                      Price = 7.99m,
                      CategoryId = 1
                  },
                  new Product
                  {
                      Id = 4,
                      Title = "Animal Farm",
                      Description = "Animal Farm is a beast fable,[1] in the form of a satirical allegorical novella, by George Orwell, first published in England on 17 August 1945.[2][3] It tells the story of a group of anthropomorphic farm animals who rebel against their human farmer, hoping to create a society where the animals can be equal, free, and happy. Ultimately, the rebellion is betrayed and, under the dictatorship of a pig named Napoleon, the farm ends up in a state as bad as it was before.",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/f/fb/Animal_Farm_-_1st_edition.jpg",
                      Price = 3.99m,
                      CategoryId = 1
                  },
                   new Product
                   {
                       Id = 5,
                       Title = "The Matrix",
                       Description = "The Matrix is a 1999 science fiction action film[5][6] written and directed by the Wachowskis.[a] It is the first installment in the Matrix film series, starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and depicts a dystopian future in which humanity is unknowingly trapped inside the Matrix, a simulated reality that intelligent machines have created to distract humans while using their bodies as an energy source.[7] When computer programmer Thomas Anderson, under the hacker alias Neo, uncovers the truth, he joins a rebellion against the machines along with other people who have been freed from the Matrix.",
                       ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/c/c1/The_Matrix_Poster.jpg",
                       Price = 19.99m,
                       CategoryId = 2
                   },
                   new Product
                   {
                       Id = 6,
                       Title = "Jurassic Park",
                       Description = "Jurassic Park is a 1990 science fiction novel written by Michael Crichton.[2] A cautionary tale about genetic engineering, it presents the collapse of a zoological park showcasing genetically recreated dinosaurs to illustrate the mathematical concept of chaos theory[3] and its real-world implications. A sequel titled The Lost World, also written by Crichton, was published in 1995. In 1997, both novels were republished as a single book titled Michael Crichton's Jurassic World.",
                       ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/21/Jurassic_Park_%28book_cover%29.jpg",
                       Price = 12.99m,
                       CategoryId = 1

                   },

                   new Product
                   {
                       Id = 7,
                       Title = "The Batman",
                       Description = "The Batman is a 2022 American superhero film based on the DC Comics character Batman. Produced by Warner Bros. Pictures, DC Films, 6th & Idaho, and Dylan Clark Productions, it is a reboot of the Batman film franchise. Directed by Matt Reeves from a screenplay he wrote with Peter Craig, it stars Robert Pattinson as Bruce Wayne / Batman alongside Zoë Kravitz, Paul Dano, Jeffrey Wright, John Turturro, Peter Sarsgaard, Andy Serkis, and Colin Farrell. The film sees Batman, who has been fighting crime in Gotham City for two years, uncover corruption while pursuing the Riddler (Dano), a serial killer who targets Gotham's corrupt elite.",
                       ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/ff/The_Batman_%28film%29_poster.jpg",
                       Price = 13.99m,
                       CategoryId = 2
                   },
                   new Product
                   {
                       Id = 8,
                       Title = "Back to the Future",
                       Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                       ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                       Price = 4.99m,
                       CategoryId = 2
                   },
                    new Product
                    {
                        Id = 9,
                        Title = "Toy Story",
                        Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                        Price = 7.99m,
                        CategoryId = 2

                    },
                    new Product
                    {
                        Id = 10,
                        Title = "Half-Life 2",
                        Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                        Price = 14.99m,
                        CategoryId = 3


                    },
                    new Product
                    {
                        Id = 11,
                        Title = "Diablo II",
                        Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                        Price = 24.99m,
                        CategoryId = 3

                    },
                    new Product
                    {
                        Id = 12,
                        Title = "Day of the Tentacle",
                        Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                        Price = 2.99m,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 13,
                        Title = "Xbox",
                        Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                        CategoryId = 3,
                        Price = 102.99m

                    },
                    new Product
                    {
                        Id = 14,
                        Title = "Super Nintendo Entertainment System",
                        Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                        CategoryId = 3,
                        Price = 73.99m
                    }

            );
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
