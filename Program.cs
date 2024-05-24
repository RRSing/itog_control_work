int showInvitation() {
    Console.WriteLine("Данный скрипт получает массив, перебирает его элементы и выводит на экран только, у которы количество символов до 3х знаков");
    Console.WriteLine("Будете использовать готовые массивы или введёте данные сами? (1-готовые, 2-сами)");
    int step1 = Convert.ToInt32(Console.ReadLine());
    return step1;
}

