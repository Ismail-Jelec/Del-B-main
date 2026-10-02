Course matte4 = new Course("Matematik 4", 3);
Course svenska3 = new Course("Svenska 3", 3);
Course engelska7 = new Course("Engelska 7", 3);
Course teknik = new Course("Teknik", 3);

Student ismail = new Student("Ismail");
Student ayaan = new Student("Ayaan");
Student kyle = new Student("Kyle");
Student perez = new Student("Sergio");

Console.WriteLine("");
matte4.RollCall();

Console.WriteLine("");

ismail.Join(matte4);
ayaan.Join(matte4);
kyle.Join(matte4);
perez.Join(matte4);
ayaan.Join(svenska3);
ayaan.Join(svenska3);


Console.WriteLine("");

ayaan.Schedule();
matte4.RollCall();

Console.WriteLine("");

Console.WriteLine(matte4.ToString());
Console.WriteLine(ismail.ToString());

Console.WriteLine("");

ismail.Leave(matte4);
matte4.RollCall();

Console.WriteLine("");

matte4.Remove(ayaan);
matte4.Enroll(perez);
engelska7.Remove(ayaan);
