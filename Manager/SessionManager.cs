using System;
namespace TaetrProjekt
{
    internal class SessionManager : ICrudService, IPrintService
    {
        private Session[] sessions = new Session[5];
        private int _currentIndex;
        public void Add(Entity entity)
        {

            if (_currentIndex > 5)
            {
                Console.WriteLine("limiti kecdiz yalniz 5 seans vardir");
                return;
            }
            sessions[_currentIndex++] = (Session)entity;
        }

        public void Delete(int id)
        {
            bool found = false;
            for (int i = 0; i < sessions.Length; i++)
            {
                if (sessions[i] == null)
                    continue;
                if (id == sessions[i].Id)

                {
                    found = true;

                    for (int j = 0; j < sessions.Length - 1; j++)
                    {
                        sessions[j] = sessions[j + 1];
                    }
                    _currentIndex--;
                    Console.WriteLine($"{id}-li session silindi");
                    return;
                }
            }

            if (!found)
                Console.WriteLine($"{id}-li session not found!");
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < sessions.Length; i++)
            {
                if (sessions[i] == null)
                    continue;
                if (sessions[i].Id == id)
                {

                    return sessions[i];
                }

            }
            Console.WriteLine("Not found!");

            return null;
        }

        public void Print()
        {
            foreach (var item in sessions)
            {
                if (item == null)
                    continue;
                Console.WriteLine(item.ToString());
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < sessions.Length; i++)
            {
                if (sessions[i] == null)
                    continue;
                if (sessions[i].Id == id)
                {
                    sessions[i] = (Session)entity;
                    Console.WriteLine("ugurla deyisdirildi!");
                    return;
                }
            }
            Console.WriteLine("not found!");
        }

        public void OccupySeat(int sessionId, int rowNo, int columnNo)
        {
            Session selectedSession = (Session)Get(sessionId);

            if (selectedSession.Seats[rowNo, columnNo] == SeatEnum.Dolu)
            {
                Console.WriteLine("Selected seat is not empty");

                return;
            }

            selectedSession.Seats[rowNo, columnNo] = SeatEnum.Dolu;

        }

        public void PrintSeats(int sessionId)
        {
            Session session = (Session)Get(sessionId);

            for (int i = 0; i < session.Seats.GetLength(0); i++)
            {
                for (int j = 0; j < session.Seats.GetLength(1); j++)
                {
                    Console.Write($"{session.Seats[i,j],-5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}

