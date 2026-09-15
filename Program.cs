Course matte4 = new Course("Matematik 4", 3);
Course svenska3 = new Course("Svenska 3", 3);
Course engelska7 = new Course("Engelska 7", 3);
Course teknik = new Course("Teknik", 3);

Student ismail = new Student("Ismail", "Jelec");
Student ayaan = new Student("Ayaan", "Khan");
Student kyle = new Student("Kyle", "Busch");
Student perez = new Student("Sergio", "Perez");

Console.WriteLine("");
matte4.RollCall();
ismail.Join(matte4);
ayaan.Join(matte4);
ayaan.Join(svenska3);
ayaan.Schedule();
matte4.RollCall();

