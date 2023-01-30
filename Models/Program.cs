namespace TaetrProjekt;
class Program
{
    static void Main(string[] args)
    {
        var filmManager = new FilmManager();
        string command = "";
        do
        {
            Console.Write("Enter the command:");
            command = Console.ReadLine();
            Film[] films =
            {
                new Film
                {
                    Id=1,
                    Name="FURY"
                },
                new Film
                {
                    Id=2,
                    Name="American Sniper"
                },
            };
            if (command.ToLower().Equals("add film"))
            {
                var film1 = new Film
                {
                    Id = 1,
                    Name = "FURY",
                    FilmDirector = "David Ayer",
                    Budget = 68000000,
                };
                var film2 = new Film
                {
                    Id = 2,
                    Name = "American Sniper",
                    FilmDirector = "Clint Eastwood",
                    Budget = 59000000,
                };
                filmManager.Add(film1);
                filmManager.Add(film2);
            }
            else if (command.ToLower().Equals("print film"))
            {
                filmManager.Print();
            }
            else if (command.ToLower().Equals("delete film"))
            {
                Console.Write("enter the id:");
                var id = int.Parse(Console.ReadLine());
                filmManager.Delete(id);
            }
            else if (command.ToLower().Equals("update film"))
            {
                Console.Write("enter the id:");
                var id = int.Parse(Console.ReadLine());
                var existFilm = filmManager.Get(id);
                if (existFilm == null)
                    continue;
                Console.WriteLine(existFilm);
                var film2 = new Film
                {
                    Id = 3,
                    Name = "vikings",
                    FilmDirector = "Clint Eastwood",
                    Budget = 100000000,
                };
                filmManager.Update(id, film2);
            }
        } while (command.ToLower() != "quit");

        {
            var hallManager = new HallManager();
            string command1 = "";
            do
            {
                Console.Write("enter the command:");
                command1 = Console.ReadLine();
                Hall[] halls =
                {
                new Hall
                {
                     Name="zal 1",
                      Id=1

                },
                new Hall
                {
                    Id=2,
                    Name="zal 2"
                },

               };
                if (command1.ToLower().Equals("add hall"))
                {
                    var hall1 = new Hall
                    {
                        Name = "zal 1",
                        Id = 1,
                        Column = 20,
                        Raw = 10
                    };
                    var hall2 = new Hall
                    {
                        Id = 2,
                        Name = "zal 2",
                        Column = 20,
                        Raw = 10

                    };
                    hallManager.Add(hall1);
                    hallManager.Add(hall2);
                }
                else if (command1.ToLower().Equals("print hall"))
                {
                    hallManager.Print();
                }
                else if (command1.ToLower().Equals("delete hall"))
                {
                    Console.Write("enter the id:");
                    var id = int.Parse(Console.ReadLine());
                    hallManager.Delete(id);
                }
                else if (command1.ToLower().Equals("update hall"))
                {
                    Console.Write("Enter the id:");
                    var id = int.Parse(Console.ReadLine());
                    var existHall = hallManager.Get(id);
                    if (existHall == null)
                        continue;
                    Console.WriteLine(existHall);
                    var hall2 = new Hall
                    {
                        Id = 2,
                        Name = "zal 2",
                        Column = 20,
                        Raw = 10
                    };
                    hallManager.Update(id, hall2);
                }

            } while (command1.ToLower() != "quit");
            {
                var sessionmanager = new SessionManager();
                string command2 = "";
                do
                {
                    Console.Write("enter the command:");
                    command2 = Console.ReadLine();
                    Session[] sessions =
                    {
                new Session
                {
                     Id=1,
                      Time="11:30"
                },
                new Session
                {
                    Id=2,
                    Time="17:45"
                },
            };
                    if (command.ToLower().Equals("add session"))
                    {
                        var session1 = new Session
                        {
                            Id = 1,
                            film = "FURY",
                            hall = "zal 1",
                            Time = "11:30"
                        };
                        var session2 = new Session
                        {
                            Id = 2,
                            film = "American Sniper",
                            hall = "zal 2",
                            Time = "17:45"
                        };
                        sessionmanager.Add(session1);
                        sessionmanager.Add(session2);
                    }
                    else if (command2.ToLower().Equals("print session"))
                    {
                        sessionmanager.Print();
                    }
                    else if (command2.ToLower().Equals("delete student"))
                    {
                        Console.Write("enter the id:");
                        var id = int.Parse(Console.ReadLine());
                        sessionmanager.Delete(id);
                    }
                    else if (command2.ToLower().Equals("update session"))
                    {
                        Console.Write("enter the id:");
                        var id = int.Parse(Console.ReadLine());
                        var existSession = sessionmanager.Get(id);
                        if (existSession == null)
                            continue;
                        Console.WriteLine(existSession);
                        var session2 = new Session
                        {
                            Id = 3,
                            Time = "19:00",
                            film = "vikings",
                            hall = "zal 3"
                        };
                        sessionmanager.Update(id, session2);
                    }
                } while (command2.ToLower() != "quit");
                var ticketManager = new TicketManager();
                string command3 = "";

                do
                {

                    Ticket[] tickets =
                    {
                    new Ticket
                    {
                         Id=1,
                          Count=2,
                            Price=10
                    },
                    new Ticket
                    {
                         Id=2,
                          Count=1,
                          Price=15
                    },

                };
                    if (command3.ToLower().Equals("add ticket"))
                    {
                        var ticket1 = new Ticket
                        {
                            Id = 1,
                            Count = 2,
                            Price = 10
                        };
                        var ticket2 = new Ticket
                        {
                            Id = 2,
                            Count = 1,
                            Price = 15
                        };
                        ticketManager.Add(ticket1);
                        ticketManager.Add(ticket2);

                    }
                    else if (command.ToLower().Equals("print ticket"))
                    {
                        ticketManager.Print();
                    }
                    else if (command.ToLower().Equals("delete ticket"))
                    {
                        Console.Write("enter the id:");
                        var id = int.Parse(Console.ReadLine());
                        ticketManager.Delete(id);
                    }
                    else if (command1.ToLower().Equals("update ticket"))
                    {
                        Console.Write("Enter the id:");
                        var id = int.Parse(Console.ReadLine());
                        var existTicket = ticketManager.Get(id);
                        if (existTicket == null)
                            continue;
                        Console.WriteLine(existTicket);
                        var ticket2 = new Ticket
                        {
                            Id = 2,
                            Count = 2,
                            Price = 12

                        };
                        hallManager.Update(id, ticket2);
                    }

                }
                    while (command3.ToLower() != "quit") ;
            }
        }
    }
}