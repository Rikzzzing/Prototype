using UnityEngine;

public class BankTester : MonoBehaviour
{
    private BankRepository _bankRepository;
    private BankInteractor _bankInteractor;

    private void Start()
    {
        _bankRepository = new BankRepository();
        _bankRepository.Initialize();

        _bankInteractor = new BankInteractor(_bankRepository);
        _bankInteractor.Initialize();

        Debug.Log($"Bank Initialized, {Bank.Coins}");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Bank.AddCoins(this, 5);
            Debug.Log($"Coins added (5), {Bank.Coins}");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Bank.SpendCoins(this, 10);
            Debug.Log($"Coins spent (10), {Bank.Coins}");
        }
    }
}