using System;

namespace Patterns.Facade
{
    sealed class ReceptionSystem
    {
        public Guid TakeMemberCard(Guid card)
        {
            // Взяти картку абонемента і видати ключ від шафки.
            Console.WriteLine("Change abonement card to key");
            return Guid.NewGuid();
        }

        public Guid ReturnMemberCard(Guid key)
        {
            // Прийняти номерок і повернути одяг.
            Console.WriteLine("Change key to abonement card");
            return Guid.NewGuid();
        }

        public void InviteTrainer()
        {
            // Запрости на тренування тренера.
            Console.WriteLine("Invite trainer");
        }
    }
}
