using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRanking.Data
{
    public class Repository
    {
        Context _c;
        public Repository(Context context)
        {
            _c = context;
        }

        public IEnumerable<object> q1(int year)
        {
            return (from ranking in _c.Ranking
                    where ranking.Year == year
                    join universities in _c.Universities
                    on ranking.University.ID equals universities.ID
                    select new
                    {
                        year = ranking.Year,
                        wr = ranking.WorldRank,
                        name = universities.NameOfUniversity,
                        country = universities.Country,
                        nr = ranking.NationalRank,
                        qe = ranking.QualityOfEducation,
                        ae = ranking.AlumniEmployment,
                        qf = ranking.QualityOfFaculty,
                        p = ranking.Publications,
                        i = ranking.Influence,
                        c = ranking.Citations,
                        bi = ranking.BroadImpact,
                        ptn = ranking.Patents,
                        scr = ranking.Score
                    }).ToList();
        }

        public IEnumerable<object> q2(int year)
        {   

            //Универ??
            return (from ranking in _c.Ranking
                    where ranking.Year == year
                    join universities in _c.Universities
                    on ranking.University.ID equals universities.ID //?
                    group ranking by universities.Country into grouped
                    select new
                    {
                        country = grouped.Key,
                        rating = from r in grouped orderby r.Score descending select r
                    }).ToList();
        }

        public IEnumerable<object> q3(string uni)
        {
            var uni_id = _c.Universities.Where(u => u.NameOfUniversity == uni).First().ID;

            return (from ranking in _c.Ranking
                    where ranking.University.ID == uni_id
                    join universities in _c.Universities
                    on ranking.University.ID equals universities.ID
                    orderby ranking.Year descending 
                    select ranking).ToList();
        }

        public IEnumerable<object> q4()
        {
            return (from rankings in _c.Ranking
                    join universities in _c.Universities 
                    on rankings.University.ID equals universities.ID
                    group rankings by universities.NameOfUniversity into grouped
                    select new
                    {
                        name = grouped.Key,
                        min = grouped.Min(n => n.Score),
                        max = grouped.Max(n => n.Score),
                        avg = grouped.Average(n => n.Score)
                    }).OrderByDescending(g => g.avg).ToList();
        }
    }
}
