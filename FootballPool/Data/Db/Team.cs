using System.ComponentModel.DataAnnotations.Schema; 
using System.ComponentModel.DataAnnotations; 

namespace FootballPool.Data { 
    public class Team { 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamId {get;set;}
        public string Location {get;set;}
        public string Mascot {get;set;}
        public string Image {get;set;}
        public string BackgroundColor {get;set;}
        public string Color{get;set;}
    }
}