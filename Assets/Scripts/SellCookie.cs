﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookie : MonoBehaviour
{
   public GameObject textBox;
   public GameObject statusBox;
   
   public void ClickTheButton()
   {
      if (GlobalCounter.CookieCount == 0)
      {
         statusBox.GetComponent<Text>().text = "Not enough cookies to sell.";
         statusBox.GetComponent<Animation>().Play("StatusAnimation2");
      }
      else
      {
         GlobalCounter.CookieCount -= 1;
         GlobalCash.CashCount += 1;
      }
      
   }
}
