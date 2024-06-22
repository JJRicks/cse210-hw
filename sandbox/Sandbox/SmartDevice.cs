using System.Dynamic;

public class SmartDevice {
    public string deviceName { get; set; }
    public bool onState { get; set; } // add some authentication to the setter or something
    public int onForSeconds { get; set; }


    public void toggleOnState() {
        if (onState){
            onState = false;
        } else {
            onState = true;
        }
    }



}