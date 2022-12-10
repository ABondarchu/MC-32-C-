using System;
				
public class MyClassA {
	int a, b;

	public MyClassA(int a, int b) {
		this.a = a;
		this.b = b;
	}
	
	    public int A {
		get { return a; }
	}
    	public int B {
		get { return b; }
	}
	
    	public int C1 {
		get { return a*b; }
	}
	    public int C2 {
		get { return ++a; }
	}
    	public float C3 {
		get { return a/b; }
	}
}


public class MyClassB: MyClassA {
    // FIELDS (also MyClassA fields)
	float d;
	float[] arr;
	
	public MyClassB(int a, int b, float d): base(a, b) {
		this.d = d;
	}

	public MyClassB(): this(2, 9, 1.97F) {
		this.d = 6.32F;
	}

	public MyClassB(int a): this(a, 1, 8.18F) {
	    this.d = 7.2F;
	    arr = new float[A];
	    for(int i = 0; i < A; i++){
			arr[i] = C4 * i;
		}
	}

	public float D {
		get { return d; }
	}
	
	public float[] Arr{
		get { return arr; }
	}
  
	public float C4 {
		get {
		    float i = 0F; 
		    do i += d/(A-B); while(i < 50);
			return i;
		}
	}
}


public class Program {
	public static void Main() {
	    MyClassB object_B = new MyClassB(10);
	    foreach(float element in object_B.Arr) Console.WriteLine(element);
	}
}
