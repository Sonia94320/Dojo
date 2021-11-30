using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DojoService
{
    public class Dojo : IDojo
    {
        public List<Arme> ListerArmes()
        {
            return null; // new List<Arme>(); 
        }
        
        public void AjouterSamourai()
        {
        }
    }
}
