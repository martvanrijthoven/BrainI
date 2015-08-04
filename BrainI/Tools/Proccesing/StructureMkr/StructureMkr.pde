
import controlP5.*;

PrintWriter csv;
PrintWriter desc;

String name;

PImage bg;
ArrayList points;

ControlP5 cp5;  
Textfield n;
PImage image;
String plane = "SagittalMedial";


void setup() {
   // open((sketchPath("")+"testfile.txt"));
    //selectInput("Select a file to process:", "fileSelected");
    background(0);
    bg = loadImage(plane+".Plane.png");
    size(bg.width, bg.height+50);
    points = new ArrayList();
    stroke(255,14,100);
    fill(255);
    cp5 = new ControlP5(this);
    n = cp5.addTextfield("name").setPosition(0, bg.height+25).setSize(200, 10).setAutoClear(false);
    cp5.addButton("create").setPosition(205, bg.height+25).setSize(40,10);
}
 
void draw() {
    //if (image==null) return;
    background(0);
    image(bg,0,0);
    for(int p=0, end=points.size(); p < end; p++) {
        Point pt = (Point) points.get(p);
        if(p < end-1) {
            Point next = (Point) points.get(p+1);       
            line(pt.x,pt.y,next.x,next.y); 
        }
        pt.draw(); 
   }
}

public void create(int v) {
    name =n.getText();
    write();
}

void mouseClicked() {
     if(!(mouseY<=bg.height))return;
     points.add(new Point(mouseX,mouseY));
     redraw();
}

void write(){
    csv = createWriter("../../../Models/Data/Structures/"+name+"/csv/"+plane+"."+name+".csv"); 
    desc = createWriter("../../../Models/Data/Structures/"+name+"/Descriptions/"+name+".txt");
    println("write:");
    for(int p=0, end=points.size(); p < end; p++) {
        Point pt = (Point) points.get(p);
        println(pt.x +","+pt.y);
        csv.println(pt.x +","+pt.y);
    }
    csv.flush();  // Writes the remaining data to the file
    csv.close();  // Finishes the file  
    desc.flush();  // Writes the remaining data to the file
    desc.close();  // Finishes the file  
}

void fileSelected(File selection) {
  if (selection == null) {
    println("Window was closed or the user hit cancel.");
  } else {
    println("User selected " + selection.getAbsolutePath());
  }
}


//class Point
class Point {
     int x,y;
     Point(int x, int y) { 
         this.x=x; 
         this.y=y; 
     }
     void draw() { 
         ellipse(x,y,5,5); 
     }
}
