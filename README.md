Using MayaEngine:

// creates an empty Entity
Entity entity = new Entity("MayaGameTest");
			
// set window style, initialize before drawing to get style
MainWindow.WindowStyle = "twin";

Styles:
bolt, twin, shadowLow, shadowMiddle, shadowHigh, half, halfUp, halfDown, black&white, thin, arrow



// Drawing Entity Main Window
entity.DrawMainWindow("middle", ConsoleColor.DarkGray);  
		
Dimensions:
small, middle, full

		
// Timer/update and fps count, initialize after drawing 
entity.InitTimer();

