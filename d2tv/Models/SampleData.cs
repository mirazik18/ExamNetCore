using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace d2tv.Models
{
    public class SampleData
    {
      
    
        public static void Initialize(D2Context d2Context)
        {
          
        List<News> news = new List<News>();
            List<Team> teams = new List<Team>();
            List<Country> countries = new List<Country>();
            List<Player> players = new List<Player>();
           
            if (!d2Context.News.Any())
            {
                 news = new List<News>
            {
                 new News{ Title="9Pasha joined the Na'Vi", Body="9Pasha has been moved out to Natus Vincere from the Virtus'Pro", Image="why"},
                 new News{ Title="Blizzy benched the Navi", Body="Blizzy had only one hero in his pool because of that Na'Vi didn't win the RNG", Image="why"}
            };
                news.ForEach(p => d2Context.News.Add(p));
                d2Context.SaveChanges();
            }
           
            if (!d2Context.Countries.Any())
            {
                countries = new List<Country>
            {
                new Country{DoubleFormat="RU", ThirdFormat="RUS" },
                new Country{DoubleFormat = "UA", ThirdFormat = "UKR"},
                new Country{DoubleFormat = "KG", ThirdFormat = "KGZ"}
            };
                countries.ForEach(p => d2Context.Countries.Add(p));

                d2Context.SaveChanges();
            }
            if (!d2Context.Teams.Any())
            {
                teams = new List<Team>()
                {
                    new Team{ Rating=115, Name="Natus Vincere", Tag="Na'Vi", Wins=23, Losses=23, LogoUrl="https://riki.dotabuff.com/t/l/3QxyeKbMK6.png"}
                };
                teams.ForEach(p => d2Context.Teams.Add(p));
                d2Context.SaveChanges();
            }
            if (!d2Context.Players.Any())
            {
                players = new List<Player>()
                {
                    new Player{GameName="9pasha", CountyCodeId=1, TeamId=1, RealName="Павел Хватсунов",
                    EarnedMoney =1010000, Role="3", PositionInGame= "Hard", SteamProfileUrl="https://ru.dotabuff.com/players/92423451",
                        AvatarUrl ="https://riki.dotabuff.com/ppa/6FnYp/6616fe10d60fb17c460d30ee5562a9f44a2109ca"},

                    new Player{GameName="Magical", CountyCodeId=2, TeamId=1, RealName="Иван Варданьян",
                    EarnedMoney=37000, Role="2", PositionInGame="Middle", SteamProfileUrl="https://ru.dotabuff.com/esports/players/171981096-na-vi-magical",
                    AvatarUrl="https://riki.dotabuff.com/ppa/Bdc8e/4f5d1e4be7737a89a54b065bd7e2313f02d729d9"},

                    new Player{GameName="Crystallize", CountyCodeId=2, TeamId=1, RealName="Владислав Кристанек",
                    EarnedMoney =66200, Role="1", PositionInGame="Carry", SteamProfileUrl="https://ru.dotabuff.com/esports/players/114619230-na-vi-crystallize",
                    AvatarUrl="https://riki.dotabuff.com/ppa/7kvhG/30e0a06d7dd24bb7ee8d79eb7ca212079c48273d"},

                    new Player{GameName="SoNNeiKo", CountyCodeId=1, TeamId=1, RealName="Акбар Бутаев",
                    EarnedMoney=85000, Role="5", PositionInGame="Hard Support", SteamProfileUrl="https://ru.dotabuff.com/esports/players/117421467-na-vi-sonneiko",
                    AvatarUrl="https://riki.dotabuff.com/ppa/7wggd/1dab550ae5fbaa313b26f8f8d401859b9d76d220"},

                    new Player{GameName="Zayac", CountyCodeId=3, TeamId=1, RealName="Бакыт Эмилжанов",
                    EarnedMoney=27000, Role="4", PositionInGame="Soft Support", SteamProfileUrl="https://ru.dotabuff.com/esports/players/111030315-na-vi-zayac",
                    AvatarUrl="https://riki.dotabuff.com/ppa/7Vs3X/4e034248da8b53cc5847a2206ce359d1854c10fa"}
                };
                players.ForEach(p => d2Context.Players.Add(p));
                d2Context.SaveChanges();
            }
         
                
           


        }
    }
}
