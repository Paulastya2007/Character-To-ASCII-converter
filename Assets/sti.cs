using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sti : MonoBehaviour
{
    public InputField tk;
    public string pt,apm;public char ta;public Text k;
    
    public void funk() {
        apm = tk.text;
        ta=char.Parse(apm);
        int p = ta;
        pt = p.ToString();
        k.text = pt;
    }
    
}