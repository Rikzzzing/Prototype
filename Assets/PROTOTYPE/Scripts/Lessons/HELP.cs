using System.Collections.Generic;
using UnityEngine;

public class HELP : MonoBehaviour
{
    private void OnEnable()
    {
        #region ОПРЕДЕЛЕНИЯ

        #region переменная
        // Переменная - поименованная или адресуемая иным способом область памяти,
        // адрес которой используется для осуществления доступа к данным или
        // их изменения в ходе работы программы.
        #endregion

        #region конкатенация
        // Конкатенация - сложение двух и более строк.
        #endregion

        #region интерполяция
        // Интерполяция - краткая форма записи конкатенации строк:
        // $"Cтрока с переменной: {переменная}".
        #endregion

        #region конвертация
        // Конвертация - перевод одного типа данных к другому.
        #endregion

        #region функция
        // Функция - поименованная часть программы, которая может быть вызвана
        // в других частях программы неограниченное количество раз.
        // Функция может принимать параметры.
        // Функция всегда возвращает значение какого-либо типа.
        #endregion

        #region процедура
        // Процедура - поименованная часть программы, которая может быть вызвана
        // в других частях программы неограниченное количество раз.
        // Процедура может принимать параметры.
        // Процедура НЕ возвращает никаких значение.
        #endregion

        #region параметры и аргументы
        // Параметры - те данные, которые хочет получить функция
        // Аргументы - те значения, которые мы передаем в функцию
        #endregion

        #region коллекции
        // Коллекции - программный объект, содержащий в себе набор одного или нескольких типов
        #endregion

        #region поле
        // Поле - переменная, определенная на уровне класса
        #endregion

        #region метод
        // Метод - функция, определенная на уровне класса
        #endregion

        #region конструктор
        // Конструктор - набор инструкций, вызываемых при создании объекта
        #endregion

        #region свойство
        // Свойство - способ доступа к внутреннему состоянию объекта, имитирующий переменную некоторого типа
        #endregion

        #region виртуальный метод
        // Виртуальный метод - метод, который может переопределяться в классах-наследниках
        #endregion

        #region интерфейс
        // Интерфейс - класс, имеющий набор методов и свойств без реализации.
        // В интерфейсе НЕ может быть полей.
        #endregion

        #region абстрактный класс
        // Абстрактный класс - класс, имеющий набор абстрактных методов без реализации.
        // Абстрактный класс может иметь и реализованные методы.
        // Нельзя создавать экземпляры абстрактных классов.
        #endregion

        #endregion

        #region ТИПЫ ПЕРЕМЕННЫХ

        #region основные

        int iVariable;
        float fVariable;
        char cVariable;
        string sVariable;
        bool bVariable;

        #endregion

        #region целочисленные

        byte byteVariable;      // от 0 до 255
        sbyte sbyteVariable;    // от -128 до 127
        short shortVariable;    // от -32768 до 32767
        ushort ushortVariable;  // от 0 до 65535
        int intVariable;        // от -2147483648 до 2147483647
        uint uintVariable;      // от 0 до 4294967295
        long longVariable;      // от -9223372036854775808 до 9223372036854775807
        ulong ulongVariable;    // от 0 до 18446744073709551615

        #endregion

        #region с плавающей запятой

        float floatVariable;    // точность до 7 знаков после запятой
        double doubleVariable;  // точность до 15 знаков после запятой

        #endregion

        #region символьный

        char charVariable;      // charVariable = 'g'

        #endregion

        #region строковый

        string stringVariable;  // stringVariable = "Hello"
                                // string - массив char, поэтому можно обращаться к элементам string по индексу,
                                // но только на чтение: char charFromString = stringVariable[3]

        #endregion

        #region логический

        bool boolVariable;      // boolVariable = true;

        #endregion

        #region ССЫЛОЧНЫЕ

        #region одномерные массивы

        int[] array1 = new int[4];
        int[] array2 = new int[4] { 1, 2, 3, 4 };
        int[] array3 = { 4, 5, 6 };

        #endregion

        #region двумерные массивы

        int[,] matrix1 = new int[4, 4];
        int[,] matrix2 = new int[4, 4]
        {
                    { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 9, 8, 7, 6 },
                    { 5, 4, 3, 2 }
        };
        int[,] matrix3 = { { 1, 2 }, { 3, 4 } };

        // Приравнивание массивов (array1 = array2) ведет к тому,
        // что две разные переменные будут указывать на одну область памяти.
        // Изменение одного массива в таком случае измененит содержание второго массива.
        #endregion

        #region КОЛЛЕКЦИИ

        #region List

        List<string> names = new List<string>(3) { "Tom", "Bob", "Sam" };

        names[0] = "Можно обращаться по индексу";
        names.Add("Добавлять можно через функцию");

        #endregion

        #region Queue

        Queue<string> visitors = new Queue<string>();

        visitors.Enqueue("Добавление элемента в очередь");
        visitors.Peek();        // получить первого в очереди без удаления из очереди
        visitors.Dequeue();     // получить первого в очереди с удалением из очереди

        #endregion

        #region Stack

        Stack<string> stackOfBooks = new Stack<string>();

        stackOfBooks.Push("Война и мир");
        stackOfBooks.Push("1984");
        stackOfBooks.Push("Мы");
        stackOfBooks.Push("Ромео и Джульетта");
        stackOfBooks.Push("Мцыри");

        stackOfBooks.Peek();    // получить первого в очереди без удаления из очереди
        stackOfBooks.Pop();     // получить первого в очереди с удалением из очереди

        #endregion

        #region Dictionary

        Dictionary<string, string> autorsOfBooks = new Dictionary<string, string>();

        autorsOfBooks.Add("Алхимик", "П.Коэльо");
        autorsOfBooks.Add("Капитанская дочка", "А.Пушкин");

        string autor = autorsOfBooks["Алхимик"];    // обращение по ключу
        bool hasABook = autorsOfBooks.ContainsKey("О дивный новый мир");

        #endregion

        #endregion

        #region классы
        #endregion

        #endregion

        #endregion

        #region ПРАВИЛА ИМЕНОВАНИЯ

        #region образцы

        // ОБРАЗЕЦ переменной: string nameOfVariable
        // ОБРАЗЕЦ переменной: bool isEmpty, canShoot, hasItems

        // ОБРАЗЕЦ функции: void DoVeryImportantFunction()
        // ОБРАЗЕЦ функции: bool CheckIsFull(), CheckCanShoot(), CheckHasItems()

        // ОБРАЗЕЦ класса: class InventorySlot
        // ОБРАЗЕЦ класса: class InventoryItem

        // ОБРАЗЕЦ private поля класса: private bool _isEquipped, _canJump, _hasParent
        // ОБРАЗЕЦ private поля класса: private int _countOfPlayers

        // ОБРАЗЕЦ public поля класса: public bool IsNotActive, CanDoSomething, HasParametrs
        // ОБРАЗЕЦ public поля класса: public int CapacityOfInventory

        // ОБРАЗЕЦ метода: private void DoVeryImportantFunction()
        // ОБРАЗЕЦ метода: public bool CheckIsFull(), CheckCanShoot(), CheckHasItems()

        // ОБРАЗЕЦ интерфейса: interface IInventoryItem
        // ОБРАЗЕЦ интерфейса: interface IJumpable

        #endregion

        #region переменные

        // 1) Именуем с маленькой буквы, если имя переменной составное, 
        // то последующие слова с большой буквы.
        // 2) переменные типа bool именуются начиная с is/can/has
        // (состояние объекта/способность объекта выполнять какие-то действия/наличие чего-то)
        // 3) Имя должно быть осознанным!

        // ОБРАЗЕЦ: string nameOfVariable

        #endregion

        #region функции

        // 1) именуем с большой буквы как первое, так и последующие слова
        // 2) первое слово - глагол
        // 3) имя должно быть осознанным!

        // ОБРАЗЕЦ: void DoVeryImportantFunction()

        #endregion

        #region классы

        // 1) именуем с большой буквы как первое, так и последующие слова
        // 2) первое слово - существительное
        // 3) имя должно быть осознанным!

        // ОБРАЗЕЦ: class InventorySlot

        #endregion

        #region поля

        // 1) приватные поля именуются начиная с _
        // 2) первое слово после _ начинается с маленькой буквы
        // 3) если имя переменной составное, то последующие слова с большой буквы.
        // 4) имя должно быть осознанным!

        // ОБРАЗЕЦ: private bool _isEquipped

        // 1) публичные поля именуются с большой буквы
        // 2) если имя переменной составное, то последующие слова с большой буквы.
        // 3) имя должно быть осознанным!

        // ОБРАЗЕЦ: public int CapacityOfInventory

        #endregion

        #region методы

        // Правила аналлогичны функциям

        #endregion

        #region интерфейсы

        // Именуется, начиная с буквы I
        // Остальные правила аналогичны классам

        #endregion

        #endregion

        #region необязательные параметры функции

        int VeryImportantFunction(int variableA, int variableB = 3)
        {
            return variableA + variableB;
        }

        VeryImportantFunction(4);       // передаем только variableA (variableB по умолчанию будет равна 3)
        VeryImportantFunction(4, 4);    // передаем variableA и variableB
        #endregion

        #region автореализуемые свойства

        // Когда нам нужно защитить поле класса от его изменения извне, мы можем
        // использовать модификатор доступа private, однако в таком случае
        // мы не сможем не только установить новое значение для поля,
        // но и считать его, если это необходимо.
        // Мы могли бы написать отдельный метод, возвращающий значение требуемого поля,
        // но это долго и неудобно/
        // поэтому используют свойства:
        // private int _amount {get;} - только на чтение
        // private int _amount {get; protected set;} - на чтение и запись внутри этого класса и классов-наследников
        // private int _amount {get; private set;} - на чтение и запись только внутри этого класса
        // private int _amount {get; set;} - на чтение и запись

        #endregion
    }

    #region виртуальный метод

    public class Warior
    {
        private int _health;

        public virtual int GetHealth()
        {
            return _health;
        }
    }

    public class Knigth: Warior
    {
        public override int GetHealth()
        {
            return 100;
        }
    }

    #endregion

    #region для тестирования

    private void Start()
    {
        Warior warior1 = new Warior();
        Warior warior2 = new Knigth();
        Knigth warior3 = new Knigth();


        Debug.Log(warior1.GetHealth());
        Debug.Log(warior2.GetHealth());
        Debug.Log(warior3.GetHealth());
    }

    #endregion
}