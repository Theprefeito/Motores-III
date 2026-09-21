using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public static class JogadorOM 
{
    public static Action CollectedCoin;
   
    public static Action<int> ChangeCoins;

    //public static PlayerInput playerInput;

    public static void CoinsAreChanged(int quantidade)
    {
        ChangeCoins?.Invoke(quantidade);
    }
    
    public static void CoinAreCollected()
    {
        CollectedCoin?.Invoke();

        //InputUser.PerformPairingWithDevice(Keyboard.current, playerInput.user);
    }
    
}