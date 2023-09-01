using VRBike.Models;
namespace VRBike.Data
{
    public class DbInitializer
    {
        public static void Initialize(VRBikeContext context) {

            var tours = new Tour[]
            {

                new Tour{Title="By bike tra vigne e parchi" , Raccolta="local", Percorso="Bussolengo Pacengo Garda", Description="Terre del Custoza"},
                 new Tour{Title="tour 16" , Raccolta="local", Percorso="Sommacampagna Villafranca", Description="Terre del Custoza"},
                  new Tour{Title="Eurovelo 7" , Raccolta="national", Percorso="Rovereto Garda Mantova", Description=""}

            };
        
        
        
        }
    }
}
