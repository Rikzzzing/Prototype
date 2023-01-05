using UnityEngine;

public class BankRepository : Repository
{
    private const string _KEY = "BANK_KEY";
    public int Coins { get; set; }

    public override void Initialize()
    {
        Coins = PlayerPrefs.GetInt(_KEY, 0);
    }

    public override void Save()
    {
        PlayerPrefs.SetInt(_KEY, Coins);
    }
}