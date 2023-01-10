public class BankInteractor : Interactor
{
    private BankRepository _repository;
    public int Coins => _repository.Coins;

    public BankInteractor(BankRepository repository)
    {
        _repository = repository;
    }

    public override void Initialize()
    {
        Bank.Initialize(this);
    }

    public bool IsEnoughCoins(int value)
    {
        return Coins >= value;
    }

    public void AddCoins(object sender, int value)
    {
        _repository.Coins += value;
        _repository.Save();
    }

    public void SpendCoins(object sender, int value)
    {
        _repository.Coins -= value;
        _repository.Save();
    }
}