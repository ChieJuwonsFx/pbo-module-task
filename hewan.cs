using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();
        Hewan hewan1= new Hewan("Sepi", 6);
        Singa singa = new Singa("Rana", 8, 4);
        Gajah gajah = new Gajah("Raksa", 7, 4);
        Ular ular = new Ular("Laru", 3, 4.1d);
        Buaya buaya = new Buaya("Kevin", 8, 3.3d);

        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine();

        singa.Mengaum();
        Console.WriteLine();

        Console.WriteLine(singa.InfoHewan());
        Console.WriteLine();

        ular.Merayap();
        Console.WriteLine();

        Reptil reptil = new Buaya("Yanto", 3, 5.4d);
        Console.WriteLine(reptil.Suara());
        Console.WriteLine();

        Console.WriteLine(hewan1.Suara());
        Console.WriteLine(hewan1.InfoHewan());
        Console.WriteLine();

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);
        Console.WriteLine();
        kebunBinatang.DaftarHewan();
    }
}
public class Hewan
{
    public string Nama;
    public int Umur;
    public Hewan(string nama, int umur)
    {
        this.Nama = nama;
        this.Umur = umur;
    }
    public virtual string Suara()
    {
        return "Hewan ini bersuara.";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun.";
    }
}

public class Mamalia : Hewan
{
    public int JumlahKaki;
    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        this.JumlahKaki = jumlahKaki;
    }
    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}.";
    }
}

public class Reptil : Hewan
{
    public double PanjangTubuh;
    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        this.PanjangTubuh = panjangTubuh;
    }
    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh}";
    }
}

public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {

    }
    public override string Suara()
    {
        return "Singa mengaum dengan keras.... Uaummmmmm aum";
    }
    public void Mengaum()
    {
        Console.WriteLine("Singa Mengaum... Aummmm");
    }
}

public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {

    }
    public override string Suara()
    {
        return "Gajah bersuara seperti terompet...";
    }
}

public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {

    }
    public override string Suara()
    {
        return "Ular sedang mendesis... sisssssss";
    }
    public void Merayap()
    {
        Console.WriteLine("Ular sedang merayap-rayap di tanah");
    }
}

public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {

    }
    public override string Suara()
    {
        return "Kamu kalau butuh apa-apa, bilang ke aku ya";
    }
}

public class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
        Console.WriteLine($"{hewan.Nama} berhasil masuk ke Kebun Binatang.");
    }

    public void DaftarHewan()
    {
        Console.WriteLine("\nDaftar Hewan yang Ada di Kebun Binatang:");
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
            Console.WriteLine(hewan.Suara());
        }
    }
}
