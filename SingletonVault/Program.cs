// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var vault1 = SingletonVault.Vault.Instance;
vault1.getKey();

var vault2 = SingletonVault.Vault.Instance;
vault2.getKey();


