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

        // States
        public Guid createState(State state)
        {
            state.Id = Guid.NewGuid();
            context.States.Add(state);
            context.SaveChanges();

            return state.Id;
        }


        public IList<State> GetStates()
        {
            return context.States.ToList();
        }


        public State GetState(Guid id)
        {
            return context.States.Find(id);
        }



// Local Government Area
        public Guid createLga(Lga lga)
        {
            lga.Id = Guid.NewGuid();
            context.Lgas.Add(lga);
            context.SaveChanges();

            return lga.Id;
        }


        public IList<Lga> GetLgas()
        {
            return context.Lgas.ToList();
        }


        public IList<Lga> GetLgasByState(Guid stateId)
        {
            return context.Lgas.Where(lg=>lg.StateId == stateId).ToList();
        }


        public Lga GetLga(Guid id)
        {
            return context.Lgas.Find(id);
        }

        public bool UpdateState(State CurrentState)
        {

            if (CurrentState.Id != Guid.Empty)
            {
                context.States.Attach(CurrentState);
                context.SaveChanges();

                return true;
            }

            return false;
        
        }

        // Queries
        public Guid createQuery(Query query)
        {
            context.Queries.Add(query);
            context.SaveChanges();

            return query.Id;
        }

        public IList<Query> GetQuery()
        {
            return context.Queries.ToList();
        }

    
    }
}
