using System.Collections.Generic;
using UnityEngine;

public class HELP : MonoBehaviour
{
    private void OnEnable()
    {
        #region �����������

        #region ����������
        // ���������� - ������������� ��� ���������� ���� �������� ������� ������,
        // ����� ������� ������������ ��� ������������� ������� � ������ ���
        // �� ��������� � ���� ������ ���������.
        #endregion

        #region ������������
        // ������������ - �������� ���� � ����� �����.
        #endregion

        #region ������������
        // ������������ - ������� ����� ������ ������������ �����:
        // $"C����� � ����������: {����������}".
        #endregion

        #region �����������
        // ����������� - ������� ������ ���� ������ � �������.
        #endregion

        #region �������
        // ������� - ������������� ����� ���������, ������� ����� ���� �������
        // � ������ ������ ��������� �������������� ���������� ���.
        // ������� ����� ��������� ���������.
        // ������� ������ ���������� �������� ������-���� ����.
        #endregion

        #region ���������
        // ��������� - ������������� ����� ���������, ������� ����� ���� �������
        // � ������ ������ ��������� �������������� ���������� ���.
        // ��������� ����� ��������� ���������.
        // ��������� �� ���������� ������� ��������.
        #endregion

        #region ��������� � ���������
        // ��������� - �� ������, ������� ����� �������� �������
        // ��������� - �� ��������, ������� �� �������� � �������
        #endregion

        #region ���������
        // ��������� - ����������� ������, ���������� � ���� ����� ������ ��� ���������� �����
        #endregion

        #region ����
        // ���� - ����������, ������������ �� ������ ������
        #endregion

        #region �����
        // ����� - �������, ������������ �� ������ ������
        #endregion

        #region �����������
        // ����������� - ����� ����������, ���������� ��� �������� �������
        #endregion

        #region ��������
        // �������� - ������ ������� � ����������� ��������� �������, ����������� ���������� ���������� ����
        #endregion

        #region ����������� �����
        // ����������� ����� - �����, ������� ����� ���������������� � �������-�����������
        #endregion

        #region ���������
        // ��������� - �����, ������� ����� ������� � ������� ��� ����������.
        // � ���������� �� ����� ���� �����.
        #endregion

        #region ����������� �����
        // ����������� ����� - �����, ������� ����� ����������� ������� ��� ����������.
        // ����������� ����� ����� ����� � ������������� ������.
        // ������ ��������� ���������� ����������� �������.
        #endregion

        #endregion

        #region ���� ����������

        #region ��������

        int iVariable;
        float fVariable;
        char cVariable;
        string sVariable;
        bool bVariable;

        #endregion

        #region �������������

        byte byteVariable;      // �� 0 �� 255
        sbyte sbyteVariable;    // �� -128 �� 127
        short shortVariable;    // �� -32768 �� 32767
        ushort ushortVariable;  // �� 0 �� 65535
        int intVariable;        // �� -2147483648 �� 2147483647
        uint uintVariable;      // �� 0 �� 4294967295
        long longVariable;      // �� -9223372036854775808 �� 9223372036854775807
        ulong ulongVariable;    // �� 0 �� 18446744073709551615

        #endregion

        #region � ��������� �������

        float floatVariable;    // �������� �� 7 ������ ����� �������
        double doubleVariable;  // �������� �� 15 ������ ����� �������

        #endregion

        #region ����������

        char charVariable;      // charVariable = 'g'

        #endregion

        #region ���������

        string stringVariable;  // stringVariable = "Hello"
                                // string - ������ char, ������� ����� ���������� � ��������� string �� �������,
                                // �� ������ �� ������: char charFromString = stringVariable[3]

        #endregion

        #region ����������

        bool boolVariable;      // boolVariable = true;

        #endregion

        #region ���������

        #region ���������� �������

        int[] array1 = new int[4];
        int[] array2 = new int[4] { 1, 2, 3, 4 };
        int[] array3 = { 4, 5, 6 };

        #endregion

        #region ��������� �������

        int[,] matrix1 = new int[4, 4];
        int[,] matrix2 = new int[4, 4]
        {
                    { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 9, 8, 7, 6 },
                    { 5, 4, 3, 2 }
        };
        int[,] matrix3 = { { 1, 2 }, { 3, 4 } };

        // ������������� �������� (array1 = array2) ����� � ����,
        // ��� ��� ������ ���������� ����� ��������� �� ���� ������� ������.
        // ��������� ������ ������� � ����� ������ ��������� ���������� ������� �������.
        #endregion

        #region ���������

        #region List

        List<string> names = new List<string>(3) { "Tom", "Bob", "Sam" };

        names[0] = "����� ���������� �� �������";
        names.Add("��������� ����� ����� �������");

        #endregion

        #region Queue

        Queue<string> visitors = new Queue<string>();

        visitors.Enqueue("���������� �������� � �������");
        visitors.Peek();        // �������� ������� � ������� ��� �������� �� �������
        visitors.Dequeue();     // �������� ������� � ������� � ��������� �� �������

        #endregion

        #region Stack

        Stack<string> stackOfBooks = new Stack<string>();

        stackOfBooks.Push("����� � ���");
        stackOfBooks.Push("1984");
        stackOfBooks.Push("��");
        stackOfBooks.Push("����� � ���������");
        stackOfBooks.Push("�����");

        stackOfBooks.Peek();    // �������� ������� � ������� ��� �������� �� �������
        stackOfBooks.Pop();     // �������� ������� � ������� � ��������� �� �������

        #endregion

        #region Dictionary

        Dictionary<string, string> autorsOfBooks = new Dictionary<string, string>();

        autorsOfBooks.Add("�������", "�.������");
        autorsOfBooks.Add("����������� �����", "�.������");

        string autor = autorsOfBooks["�������"];    // ��������� �� �����
        bool hasABook = autorsOfBooks.ContainsKey("� ������ ����� ���");

        #endregion

        #endregion

        #region ������
        #endregion

        #endregion

        #endregion

        #region ������� ����������

        #region �������

        // ������� ����������: string nameOfVariable
        // ������� ����������: bool isEmpty, canShoot, hasItems

        // ������� �������: void DoVeryImportantFunction()
        // ������� �������: bool CheckIsFull(), CheckCanShoot(), CheckHasItems()

        // ������� ������: class InventorySlot
        // ������� ������: class InventoryItem

        // ������� private ���� ������: private bool _isEquipped, _canJump, _hasParent
        // ������� private ���� ������: private int _countOfPlayers

        // ������� public ���� ������: public bool IsNotActive, CanDoSomething, HasParametrs
        // ������� public ���� ������: public int CapacityOfInventory

        // ������� ������: private void DoVeryImportantFunction()
        // ������� ������: public bool CheckIsFull(), CheckCanShoot(), CheckHasItems()

        // ������� ����������: interface IInventoryItem
        // ������� ����������: interface IJumpable

        #endregion

        #region ����������

        // 1) ������� � ��������� �����, ���� ��� ���������� ���������, 
        // �� ����������� ����� � ������� �����.
        // 2) ���������� ���� bool ��������� ������� � is/can/has
        // (��������� �������/����������� ������� ��������� �����-�� ��������/������� ����-��)
        // 3) ��� ������ ���� ����������!

        // �������: string nameOfVariable

        #endregion

        #region �������

        // 1) ������� � ������� ����� ��� ������, ��� � ����������� �����
        // 2) ������ ����� - ������
        // 3) ��� ������ ���� ����������!

        // �������: void DoVeryImportantFunction()

        #endregion

        #region ������

        // 1) ������� � ������� ����� ��� ������, ��� � ����������� �����
        // 2) ������ ����� - ���������������
        // 3) ��� ������ ���� ����������!

        // �������: class InventorySlot

        #endregion

        #region ����

        // 1) ��������� ���� ��������� ������� � _
        // 2) ������ ����� ����� _ ���������� � ��������� �����
        // 3) ���� ��� ���������� ���������, �� ����������� ����� � ������� �����.
        // 4) ��� ������ ���� ����������!

        // �������: private bool _isEquipped

        // 1) ��������� ���� ��������� � ������� �����
        // 2) ���� ��� ���������� ���������, �� ����������� ����� � ������� �����.
        // 3) ��� ������ ���� ����������!

        // �������: public int CapacityOfInventory

        #endregion

        #region ������

        // ������� ����������� ��������

        #endregion

        #region ����������

        // ���������, ������� � ����� I
        // ��������� ������� ���������� �������

        #endregion

        #endregion

        #region �������������� ��������� �������

        int VeryImportantFunction(int variableA, int variableB = 3)
        {
            return variableA + variableB;
        }

        VeryImportantFunction(4);       // �������� ������ variableA (variableB �� ��������� ����� ����� 3)
        VeryImportantFunction(4, 4);    // �������� variableA � variableB
        #endregion

        #region ��������������� ��������

        // ����� ��� ����� �������� ���� ������ �� ��� ��������� �����, �� �����
        // ������������ ����������� ������� private, ������ � ����� ������
        // �� �� ������ �� ������ ���������� ����� �������� ��� ����,
        // �� � ������� ���, ���� ��� ����������.
        // �� ����� �� �������� ��������� �����, ������������ �������� ���������� ����,
        // �� ��� ����� � ��������/
        // ������� ���������� ��������:
        // private int _amount {get;} - ������ �� ������
        // private int _amount {get; protected set;} - �� ������ � ������ ������ ����� ������ � �������-�����������
        // private int _amount {get; private set;} - �� ������ � ������ ������ ������ ����� ������
        // private int _amount {get; set;} - �� ������ � ������

        #endregion
    }

    #region ����������� �����

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

    #region ��� ������������

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