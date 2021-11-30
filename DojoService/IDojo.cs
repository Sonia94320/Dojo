using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DojoService
{
    [ServiceContract]
    public interface IDojo
    {
        [OperationContract]
        List<Arme> ListerArmes();

        [OperationContract]
        void AjouterSamourai();
    }

    [DataContract]
    public class Samourai
    {
        private string nom;

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        [DataMember]
        public int Force { get; set; }


        [DataMember]
        public Arme Arme { get; set; }
    }

    [DataContract]
    public class Arme
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nom { get; set; }
        
        [DataMember]
        public int Degats { get; set; }
    }
}
