using System;

public struct Worker
{
    public Worker(int id,DateTime dateAndTimeOfNote, string fio, string age, string hieght, DateTime dateOfBirth, string placeOfBirth)
    {
        this.id = id;
        this.dateAndTimeOfNote = dateAndTimeOfNote;
        this.fio = fio;
        this.age = age;
        this.hieght = hieght;
        this.dateOfBirth = dateOfBirth;
        this.placeOfBirth = placeOfBirth;
    }

    public Worker(int id)
    {
        this.id = id;
        dateAndTimeOfNote = DateTime.Now;
        Console.WriteLine("Введиде ФИО");
        fio = Console.ReadLine();
        Console.WriteLine("Введите возраст");
        age = Console.ReadLine();
        Console.WriteLine("Введите рост");
        hieght = Console.ReadLine();
        Console.WriteLine("Введите дату рождения в формате дд мм гггг");
        dateOfBirth =  Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Введите место рождения");
        placeOfBirth = Console.ReadLine();

    }



    public void ShowInConsole()
    {
        Console.WriteLine($"id = {this.id} \n Date of Note = {this.dateAndTimeOfNote}\n FIO = {this.FIO}\n Age = {this.age}\n" +
            $"Hieght = {this.hieght}\n date of birth = {this.dateOfBirth.ToShortDateString()}\n place of birth = {this.placeOfBirth}");
        Console.ReadKey();
    }


    int id;
    DateTime dateAndTimeOfNote;
    string fio;
    string age;
    string hieght;
    DateTime dateOfBirth;
    string placeOfBirth;

    public int Id { get => id; set => id = value; }
    public DateTime DateOfNote { get => dateAndTimeOfNote; set => dateAndTimeOfNote = value; }
    public string FIO { get => fio; set => fio = value; }
    public string Age { get => age; set => age = value; }
    public string Hieght { get => hieght; set => hieght = value; }
    public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    public string PlaceOfBirth { get => placeOfBirth; set => placeOfBirth = value; }
}
