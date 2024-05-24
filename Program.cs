int showInvitation() {
    Console.WriteLine("Данный скрипт получает массив, перебирает его элементы и выводит на экран только, у которы количество символов до 3х знаков");
    Console.WriteLine("Будете использовать готовые массивы или введёте данные сами? (1-готовые, 2-сами)");
    int step1 = Convert.ToInt32(Console.ReadLine());
    return step1;
}

void showArray(string[] toShow) {
    foreach (string item in toShow)
    {
        if(item.Length<=3) {
            Console.Write($"{item} ");
        }
    }
    Console.WriteLine();
}

int step1 = showInvitation();

if(step1 == 1) {
    Console.WriteLine("Вы выбрали работу с готовыми массивами");
    Console.WriteLine("1 - [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2 - [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3 - [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine("Выберите вариант от 1 до 3х");
    int step2 = Convert.ToInt32(Console.ReadLine());
    if(step2 == 1) {string[] text = ["Hello", "2", "world", ":-)"]; showArray(text);}
    if(step2 == 2) {string[] text = ["1234", "1567", "-2", "computer science"]; showArray(text);}
    if(step2 == 2) {string[] text = ["Russia", "Denmark", "Kazan"]; showArray(text);}
}
if(step1 == 2) {
    string[] text = new string[4];
    Console.WriteLine("Введите первый элемент массива");
    text[0] = Console.ReadLine();
    Console.WriteLine("Введите второй элемент массива");
    text[1] = Console.ReadLine();
    Console.WriteLine("Введите третий элемент массива");
    text[2] = Console.ReadLine();
    Console.WriteLine("Введите четвертый элемент массива");
    text[3] = Console.ReadLine();
    showArray(text);
}
if(step1 != 1 && step1 != 2) {
    showInvitation();
}
