using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRanking.Data
{
    public class Tester
    {
       // public void Test(Context context)
        //{
        //    List<University> universities = new List<University>();

        //    Assembly assembly = Assembly.GetExecutingAssembly();
        //    for (int year = 2012; year < 2017; year++)
        //    {
        //        string resourceName = "UniversityRanking.Data.Tables." + year + ".csv";
        //        using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        //        {
        //            //FileStream fs = new FileStream("../../2012.csv", FileMode.Open);
        //            using (StreamReader sr = new StreamReader(stream, Encoding.UTF8))
        //            //StreamReader sr = new StreamReader(stream);
        //            {
        //                CsvReader csvReader = new CsvReader(sr);
        //                csvReader.Configuration.WillThrowOnMissingField = false;
        //                csvReader.Configuration.Delimiter = ";";

        //                while (csvReader.Read())
        //                {
        //                    var UniversityName = csvReader.GetField<string>("Institution");
        //                    var UniversityCountry = csvReader.GetField<string>("Location");
        //                    //Line = sr.ReadLine();
        //                    //while (sr.Peek() >= 0)
        //                    //{
        //                    //    str.Add(sr.ReadLine());
        //                    //}

        //                    var university = new University { NameOfUniversity = UniversityName, Country = UniversityCountry };

        //                    if (!universities.Any(u => u.NameOfUniversity == university.NameOfUniversity))
        //                        universities.Add(university);

        //                    var RankingWR = csvReader.GetField<int>("World Rank");
        //                    var RankingNR = csvReader.GetField<int>("National Rank");
        //                    var RankingQOfEd = csvReader.GetField<int>("QA");
        //                    var RankingAlEmp = csvReader.GetField<int>("Alumni Employment");
        //                    var RankingQOfFac = csvReader.GetField<int>("QF");
        //                    var RankingPubl = csvReader.GetField<int>("Publications");
        //                    var RankingInf = csvReader.GetField<int>("Influence");
        //                    var RankingCit = csvReader.GetField<int>("Citations");
        //                    var RankingPat = csvReader.GetField<int>("Patents");
        //                    var RankingSc = csvReader.GetField<double>("Score");

        //                    var UniName = csvReader.GetField<string>("Institution");

        //                    var RankingBI = 0;
        //                    if (year > 2013)
        //                    {
        //                        RankingBI = csvReader.GetField<int>("Broad Impact");
        //                    }

        //                    var ranking1 = new Ranking
        //                    {
        //                        WorldRank = RankingWR,
        //                        Year = year,
        //                        NationalRank = RankingNR,
        //                        QualityOfEducation = RankingQOfEd,
        //                        AlumniEmployment = RankingAlEmp,
        //                        QualityOfFaculty = RankingQOfFac,
        //                        Publications = RankingPubl,
        //                        Influence = RankingInf,
        //                        Citations = RankingCit,
        //                        Patents = RankingPat,
        //                        Score = RankingSc,
        //                        BroadImpact = RankingBI
        //                    };

        //                    ranking1.University = context.Universities.Where(u => u.NameOfUniversity == UniName).First();
        //                }
        //            }
        //        }
        //    }
        }
    }

