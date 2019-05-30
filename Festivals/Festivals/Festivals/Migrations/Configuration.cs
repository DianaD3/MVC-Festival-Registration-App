namespace Festivals.Migrations
{
    using Festivals.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    internal sealed class Configuration :
   DbMigrationsConfiguration<Festivals.DAL.FestivalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
        protected override void
       Seed(Festivals.DAL.FestivalContext context)
        {
            var artists = new List<Artist>
 {
new Artist{Name="Bastille" ,Genre="Electro pop"},
new Artist{Name="David Guetta" ,Genre="House"},
new Artist{Name="James Arthur" ,Genre="Pop"},
new Artist{Name="Martin Garrix" ,Genre="Electro house"},
new Artist{Name="Dimitri Vegas&Like Mike" ,Genre="Electro house"},
new Artist{Name="Afrojack" ,Genre="Electro house"},
new Artist{Name="G-Eazy" ,Genre="Hip Hop"},
new Artist{Name="Jessie J" ,Genre="Pop"},
new Artist{Name="Dj Snake" ,Genre="Trap"},
new Artist{Name="Steve Aoki" ,Genre="Electro house"},
new Artist{Name="Derek" ,Genre="Electro house"},
new Artist{Name="Petre Inspirescu" ,Genre="Electro house"},
new Artist{Name="Jamie Jones" ,Genre="House"},
new Artist{Name="Lizz" ,Genre="Electro house"},
new Artist{Name="Arapu" ,Genre="Electro house"},
new Artist{Name="DOC" ,Genre="Hip hop"},
new Artist{Name="Cred ca sunt extraterestru" ,Genre="Rap"},
new Artist{Name="Nimeni Altu’" ,Genre="Rap"},
new Artist{Name="Subcarpati" ,Genre="Hip hop"},
new Artist{Name="CTC" ,Genre="Hip hop"},
new Artist{Name="Thirty Seconds to Mars" ,Genre="Rock "},
new Artist{Name="Subcarpati " ,Genre="Hip hop"},
new Artist{Name="CTC" ,Genre="Hip hop"},
new Artist{Name="Suie Paparude" ,Genre="Electro alternativ"},
new Artist{Name="Sofi Tukker" ,Genre="House "},
new Artist{Name="Subcarpati " ,Genre="Hip hop"},
new Artist{Name="The National" ,Genre="Indie rock "},
new Artist{Name="The 1975" ,Genre="Indie pop / Indie rock"},
new Artist{Name="Jungle" ,Genre="Modern soul"},
new Artist{Name="Pale Waves" ,Genre="Indie pop / Indie rock"},
new Artist{Name="JP Cooper" ,Genre="Soul"},
new Artist{Name="The Mono Jacks" ,Genre="Rock alternativ"},
new Artist{Name="Manuel Riva" ,Genre="Pop"},
new Artist{Name="Moonlight Breakfast" ,Genre="Pop"},
new Artist{Name="Grimus" ,Genre="Rock alternativ"},
new Artist{Name="Don Diablo" ,Genre="Electro house "},
new Artist{Name="Rita Ora" ,Genre="Pop"},
new Artist{Name="Quintino" ,Genre="Electro house"},
new Artist{Name="R3HAB" ,Genre="Electro house"},
new Artist{Name="Gareth Emery" ,Genre="Progresive house"},
new Artist{Name="Petre Inspirescu " ,Genre="Electro house"},
new Artist{Name="Nu Zau" ,Genre="Electro house"},
new Artist{Name="Asura" ,Genre="Electro alternativ"},
new Artist{Name="Piticu" ,Genre="House"},
new Artist{Name="CJ Art" ,Genre="Electro house"},
new Artist{Name="J Balvin" ,Genre="Reggaeton"},
new Artist{Name="Black Eyed Peas" ,Genre="Hip hop"},
new Artist{Name="Nicky Jam" ,Genre="Reggaeton"},
new Artist{Name="Diplo" ,Genre="Electro house"},
new Artist{Name="Young Thug" ,Genre="Hip hop"},
};
            artists.ForEach(s => context.Artist.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var festivals = new List<Festival>
{
new Festival{FestivalID=1,NameFestival="Untold",Locatie="Stadionul Cluj Arena, Cluj Napoca",Start=DateTime.Parse("2019-08-01"), Finish=DateTime.Parse("2019-08-04")},
new Festival{FestivalID=2,NameFestival="Neversea",Locatie="Plaja Neversea, Constanta",Start=DateTime.Parse("2019-07-04"), Finish=DateTime.Parse("2019-07-07")},
new Festival{FestivalID=3,NameFestival="Sunwaves",Locatie="Crazy Beach, Constanta",Start=DateTime.Parse("2019-08-15"), Finish=DateTime.Parse("2019-08-20")},
new Festival{FestivalID=4,NameFestival="Sunset",Locatie="Strada Falezei, Vama Veche",Start=DateTime.Parse("2019-08-08"), Finish=DateTime.Parse("2019-08-10")},
new Festival{FestivalID=5,NameFestival="Electric Castle",Locatie="Castelul Bánffy, Cluj",Start=DateTime.Parse("2019-07-17"), Finish=DateTime.Parse("2019-07-21")},
new Festival{FestivalID=6,NameFestival="Summer Well",Locatie="Domeniul Stirbey, Buftea",Start=DateTime.Parse("2019-08-10"), Finish=DateTime.Parse("2019-08-11")},
new Festival{FestivalID=7,NameFestival="Awake",Locatie="Domeniul Teleki, Targu Mures",Start=DateTime.Parse("2019-08-15"), Finish=DateTime.Parse("2019-08-19")},
new Festival{FestivalID=5,NameFestival="Afterhills",Locatie="Strada Vasile Lupu, Iași",Start=DateTime.Parse("2019-08-23"), Finish=DateTime.Parse("2019-08-25")},
new Festival{FestivalID=6,NameFestival="Dakini",Locatie="Plaja Tuzla, Constanta",Start=DateTime.Parse("2019-06-29"), Finish=DateTime.Parse("2019-07-02")},
new Festival{FestivalID=7,NameFestival="El Carrusel",Locatie="Romexpo, Bucuresti",Start=DateTime.Parse("2019-06-27"), Finish=DateTime.Parse("2019-06-30")},
};
            festivals.ForEach(s => context.Festival.AddOrUpdate(p => p.NameFestival, s));
            context.SaveChanges();

            var desfasuratoare = new List<Desfasurator>
 {
new Desfasurator{ArtistID=1,FestivalID=1},
new Desfasurator{ArtistID=2,FestivalID=1},
new Desfasurator{ArtistID=3,FestivalID=1},
new Desfasurator{ArtistID=4,FestivalID=1},
new Desfasurator{ArtistID=5,FestivalID=1},
new Desfasurator{ArtistID=6,FestivalID=2},
new Desfasurator{ArtistID=7,FestivalID=2},
new Desfasurator{ArtistID=8,FestivalID=2},
new Desfasurator{ArtistID=9,FestivalID=2},
new Desfasurator{ArtistID=10,FestivalID=2},
new Desfasurator{ArtistID=11,FestivalID=3},
new Desfasurator{ArtistID=12,FestivalID=3},
new Desfasurator{ArtistID=13,FestivalID=3},
new Desfasurator{ArtistID=14,FestivalID=3},
new Desfasurator{ArtistID=15,FestivalID=3},
new Desfasurator{ArtistID=16,FestivalID=4},
new Desfasurator{ArtistID=17,FestivalID=4},
new Desfasurator{ArtistID=18,FestivalID=4},

new Desfasurator{ArtistID=19,FestivalID=4},
new Desfasurator{ArtistID=19,FestivalID=5},
new Desfasurator{ArtistID=20,FestivalID=4},
new Desfasurator{ArtistID=20,FestivalID=5},

new Desfasurator{ArtistID=21,FestivalID=5},
new Desfasurator{ArtistID=24,FestivalID=5},
new Desfasurator{ArtistID=25,FestivalID=5},
new Desfasurator{ArtistID=26,FestivalID=6},
new Desfasurator{ArtistID=27,FestivalID=6},
new Desfasurator{ArtistID=28,FestivalID=6},
new Desfasurator{ArtistID=29,FestivalID=6},
new Desfasurator{ArtistID=30,FestivalID=6},
new Desfasurator{ArtistID=31,FestivalID=7},
new Desfasurator{ArtistID=32,FestivalID=7},
new Desfasurator{ArtistID=33,FestivalID=7},
new Desfasurator{ArtistID=34,FestivalID=7},
new Desfasurator{ArtistID=35,FestivalID=7},
new Desfasurator{ArtistID=36,FestivalID=8},
new Desfasurator{ArtistID=37,FestivalID=8},
new Desfasurator{ArtistID=38,FestivalID=8},
new Desfasurator{ArtistID=39,FestivalID=8},
new Desfasurator{ArtistID=40,FestivalID=8},
new Desfasurator{ArtistID=41,FestivalID=9},
new Desfasurator{ArtistID=42,FestivalID=9},
new Desfasurator{ArtistID=43,FestivalID=9},
new Desfasurator{ArtistID=44,FestivalID=9},
new Desfasurator{ArtistID=45,FestivalID=9},
new Desfasurator{ArtistID=46,FestivalID=10},
new Desfasurator{ArtistID=47,FestivalID=10},
new Desfasurator{ArtistID=48,FestivalID=10},
new Desfasurator{ArtistID=49,FestivalID=10},
new Desfasurator{ArtistID=50,FestivalID=10},
};
            foreach (Desfasurator e in desfasuratoare)
            {
                var enrollmentInDataBase = context.Desfasurator.Where(s => s.Artist.ArtistID == e.ArtistID && s.Festival.FestivalID == e.FestivalID).SingleOrDefault();
                if (enrollmentInDataBase == null)
                {
                    context.Desfasurator.Add(e);
                }
            }
            context.SaveChanges();
        }
    }
}