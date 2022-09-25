using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Activity
    {
        private string id;
        private string description;
        private decimal duration;
        private decimal est;
        private decimal lst;
        private decimal eet;
        private decimal let;
        private Activity[] successors;
        private Activity[] predecessors;

        public Activity()
        {
            // TODO: Add Constructor Logic here
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public decimal Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }

        public decimal Est
        {
            get
            {
                return est;
            }
            set
            {
                est = value;
            }
        }

        public decimal Lst
        {
            get
            {
                return lst;
            }
            set
            {
                lst = value;
            }
        }

        public decimal Eet
        {
            get
            {
                return eet;
            }
            set
            {
                eet = value;
            }
        }
        public decimal Let
        {
            get
            {
                return let;
            }
            set
            {
                let = value;
            }
        }

        public Activity[] Predecessors
        {
            get
            {
                return predecessors;
            }
            set
            {
                predecessors = value;
            }
        }

        public Activity[] Successors
        {
            get
            {
                return successors;
            }
            set
            {
                successors = value;
            }
        }

        public Activity CheckActivity(Activity[] list, string id, int i)
        {
            for (int j = 0; j < i; j++)
            {
                if (list[j].Id == id)
                    return list[j];
            }
            return null;
        }

        public int GetIndex(Activity[] list, Activity aux, int i)
        {
            for (int j = 1; j < i; j++)
            {
                if (list[j].Id == aux.Id)
                    return j;
            }
            return 0;
        }
        public Activity SetSuccessors(Activity aux, Activity activity)
        {
            if (aux.Successors != null)
            {
                Activity aux2 = new Activity();
                aux2.Successors = new Activity[aux.Successors.Length + 1];
                aux.Successors.CopyTo(aux2.Successors, 0);
                aux2.Successors[aux.Successors.Length] = activity;
                aux.Successors = aux2.Successors;
            }
            else
            {
                aux.Successors = new Activity[1];
                aux.Successors[0] = activity;
            }
            return aux;
        }
    }
}
