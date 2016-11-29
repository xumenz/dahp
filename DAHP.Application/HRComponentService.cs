using DAHP.Domain;
using DAHP.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHP.Application
{
    public class HRComponentService
    {
        HPDbContext context;
        public HRComponentService()
        {
            context = new HPDbContext();
        }

        public Guid createState(State state)
        {

            context.States.Add(state);
            context.SaveChanges();

            return state.Id;
        }


        public IList<State> GetState()
        {
            return context.States.ToList();
        }


        public State GetState(Guid id)
        {
            return context.States.Find(id);
        }




        public Guid createLga(Lga lga)
        {

            context.Lgas.Add(lga);
            context.SaveChanges();

            return lga.Id;
        }


        public IList<Lga> GetLga()
        {
            return context.Lgas.ToList();
        }


        public Lga GetLga(Guid id)
        {
            return context.Lgas.Find(id);
        }

        public bool UpdateState(State CurrentState)
        {

            if (CurrentState.Id != Guid.Empty)
            {
                context.Lgas.Attach(CurrentState);
                context.SaveChanges();

                return true;
            }

            return false;
        
        }
    }
}
