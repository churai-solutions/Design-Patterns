using System;

namespace Patterns.Structural.Facade
{
    // Представляє собою фасад докількох підсистем басейну
    public sealed class SwimmingpoolFacade
    {
        private readonly WardrobeSystem _wardrobe = new WardrobeSystem();
        private readonly ReceptionSystem _reception = new ReceptionSystem();
        private readonly SwimmingpoolSystem _swimmingpool = new SwimmingpoolSystem();

        public void GoToASwimmingPool()
        {
            _wardrobe.TakeClothes(new object());
            _reception.TakeMemberCard(Guid.NewGuid());
            _reception.InviteTrainer();
            _swimmingpool.HaveFun(new object());
            _reception.ReturnMemberCard(Guid.NewGuid());
            _wardrobe.ReturnClothes(Guid.NewGuid());
        }
    }
}
