using System;
using UnityEngine;

public static class InteractOM
{
   public static event Action OnInteract;

   public static void Interact()
   {
      OnInteract?.Invoke();
   }

   public static event Action<bool> OnInteractable;

   public static void interactable(bool value)
   {
      OnInteractable?.Invoke(value);

   }
   
   public static event Action<Vector3> OnInteractPosition;
   
   public static void interactable(bool value)
   
   
}
