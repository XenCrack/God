using System;

namespace God
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Universe.LocalSuperclusters evren = new Universe.LocalSuperclusters();
            evren.VirgoSuperCluster();*/

            Universe.LocalSuperclusters evren = new Universe.LocalSuperclusters();
            evren.LocalSupercluster();
            Universe.VirgoSupercluster basak = new Universe.VirgoSupercluster();
            basak.VirgoSuperCluster();
            Universe.LocalGalacticGroup galaksi = new Universe.LocalGalacticGroup();
            galaksi.LocalGalacticGgroup();
            Universe.MilkWayGalaxy samanyolu = new Universe.MilkWayGalaxy();
            samanyolu.MilkwayGalaxy();
            Universe.SolarInterstellerNeighborhood solar = new Universe.SolarInterstellerNeighborhood();
            solar.Solarınterstellerneighborhood();
            Universe.SolarSystem solarsistem = new Universe.SolarSystem();
            solarsistem.SolarSysteM();
            Universe.Earth dunya = new Universe.Earth();
            dunya.EartH();
            Universe.Creature canlilar = new Universe.Creature();
            canlilar.Human();
            canlilar.Animals();
            canlilar.Atom();
            canlilar.Molecules();
            canlilar.StatesofMatter();
            Console.Read();

        }
    }
}

namespace Universe
{
    public class LocalSuperclusters
    {
        public void LocalSupercluster()
        {
            Console.Write("Yerel Süper Kümeler > ");
        }
    }

    public class VirgoSupercluster: LocalSuperclusters
    {
        public void VirgoSuperCluster()
        {
            Console.Write("Başak Üstküme > ");
        }
    }

    public class LocalGalacticGroup: VirgoSupercluster
    {
        public void LocalGalacticGgroup()
        {
            Console.Write("Yerel Galaktik Gruplar > ");
        }
    }

    public class MilkWayGalaxy: LocalGalacticGroup
    {
        public void MilkwayGalaxy()
        {
            Console.WriteLine("\n");
            Console.Write("Samanyolu Galaksisi > ");
        }
    }

    public class SolarInterstellerNeighborhood: MilkWayGalaxy
    {
        public void Solarınterstellerneighborhood()
        {
            Console.Write("Yıldızlararası Güneş Çevresi > ");
        }
    }

    public class SolarSystem:SolarInterstellerNeighborhood
    {
        public void SolarSysteM()
        {
            Console.Write("Solar Sistem > ");
        }
    }

    public class Earth:SolarSystem
    {
        public void EartH()
        {
            Console.Write("Dünya > ");
        }
    }

    public class Creature:Earth
    {
        public void Human()
        {
            Console.WriteLine("\n");
            Console.Write("İnsan > ");
        }
        public void Animals()
        {
            Console.Write("Omurgalılar , Omurgasızlar > ");
        }
        public void Atom()
        {
            Console.Write("Nötron , Ploton , Elektron , Çekirdek > ");
        }
        public void Molecules()
        {
            Console.Write("Elementler ve Bakteriler > ");
        }
        public void StatesofMatter()
        {
            Console.Write("Katı,Sıvı,Gaz,Plazma  ");
        }
    }
}


