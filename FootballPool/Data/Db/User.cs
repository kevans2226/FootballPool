using System.ComponentModel.DataAnnotations.Schema; 
using System.ComponentModel.DataAnnotations; 

namespace FootballPool.Data { 
    public class User { 
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId {get;set;}
        [MaxLength(100),Required]
        public string UserName{get;set;}
        [MaxLength(200),Required]
        public string UserEmail{get;set;}
        [MaxLength(100),Required]
        public string FirstName{get;set;}
        [MaxLength(100)]
        public string LastName{get;set;}
        [MaxLength(200)]
        public string Address{get;set;}
        [MaxLength(100)]
        public string City{get;set;}
        [MaxLength(2)]
        public string State{get;set;}
        [MaxLength(10)]
        public string ZipCode{get;set;}
        [MaxLength(20)]
        public string HomePhone{get;set;}
        [MaxLength(20)]
        public string CellPhone{get;set;}
        [MaxLength(1)]
        public string MartialStatus{get;set;}
        public int Kids{get;set;}
        [MaxLength(200)]
        public string OtherFamilyInfo{get;set;}
        [MaxLength(200)]
        public string Occupation{get;set;}
        public int Age{get;set;}
        [MaxLength(30)]
        public int FavoriteNFLTeamId {get; set; }
        [MaxLength(200)]
        public string FavoriteWebSite{get;set;}
        [MaxLength(300)]
        public string Comments{get;set;}
        public bool Paid {get;set;}
        public bool SignedUp{get;set;}
        [MaxLength(200)]
        public string BirthPlace{get;set;}
        [MaxLength(200)]
        public string HighSchool{get;set;}
        [MaxLength(200)]
        public string BrushWithGreatness {get;set;}
        [MaxLength(200)]
        public string InterestingTidbits{get;set;}
        public string SentEmail{get;set;}
        public string Twitter{get;set;}
        public string Instagram{get;set;}

    }
}