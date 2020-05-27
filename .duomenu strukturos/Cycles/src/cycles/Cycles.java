package cycles;
import java.util.*; 

  
// This class represents a directed graph using adjacency list 
// representation 
class Graph
{ 
    private int V;   // No. of vertices 
    
    // Array  of lists for Adjacency List Representation 
    private  LinkedList<Integer> adj[]; 
    private LinkedList<Integer> nr;
    private  LinkedList<Integer> prec;
    private  LinkedList<Integer>[] cyclesList;
   
    private  int cyclesNumber;
    // Konstruktorius
    Graph(int v) 
    { 
        V = v; 
        adj = new LinkedList[v]; 
        prec = new LinkedList();
        nr = new LinkedList();
        cyclesList= new LinkedList[v];
        cyclesNumber=1;
        for (int i=0; i<v; ++i) 
        {
            adj[i] = new LinkedList(); 
            cyclesList[i]= new LinkedList();
            prec.add(0);
             nr.add(0);
        }
        
    } 
     public LinkedList<Integer>[] getADJ()
    {
        return adj; 
    }
    public int getV(){
        return this.V;
    }
    public LinkedList<Integer>[] getCycles()
    {
        return cyclesList;
    }
    public int getCyclesNumber()
    {
        return cyclesNumber;
    }
  
    //Function to add an edge into the graph 
    void addEdge(int v, int w) 
    { 
        adj[v].add(w);  // Add w to v's list. 
        adj[w].add(v);
    } 
  
    // A function used by DFS 
    void searchRecursive(int v,boolean visited[], int previous) 
    { 
        // pazymi aplankyta virsune masyve
        visited[v] = true; 
      
        int sk=0; // ciklas tikrina kuriuo numeriu ideti nauja virsune
        for (int i=0;i< nr.size();i++)
        {
            if (nr.get(i)!=0) sk++;
        }
        nr.set(v, sk+1); // tuo skaiciumi idedama i nr
        prec.set(v, previous); // i prec irasoma is kurios virsunes atejo
        previous=nr.indexOf(sk+1); // dabartine virsune nustatoma kaip buvusi
         
        
        //toliau ieskoma gilyn
        Iterator<Integer> i = adj[v].listIterator(); 
        while (i.hasNext()) 
        { 
           //iteruoja
            int n = i.next(); 
            
            //jeigu virsune neaplankyta, ji pridedama ir ieskoma nuo jos
            if (!visited[n]) 
                searchRecursive(n, visited, previous);
            if (nr.get(n)<nr.get(v)&&prec.get(v)!=n){ // tikrina ar ciklas
                cyclesList[cyclesNumber].add(n);
                cyclesList[cyclesNumber].add(v);
                int a= prec.get(v);
                while (prec.get(a)!=n)
               {
                   cyclesList[cyclesNumber].add(a);
                    a=prec.get(a);
                }
                cyclesList[cyclesNumber].add(a);
                cyclesList[cyclesNumber].add(n);
                // ivykdytas ciklas, padidinamas ciklu skaicius
                cyclesNumber++;

            }
        }
    }
    //spausdina i console
    void consoleOutput(){
        for (int i=1; i< cyclesNumber;i++)
        {
            System.out.print("Ciklo nr " + i + ": ");
            for (int x: cyclesList[i])
            {
                System.out.print(x+ " ");
            }
            System.out.println("");
        }
        
    }
  
    // The function to do DFS traversal. It uses recursive DFSUtil() 
    void search(int v) 
    { 
        //visu aplankytu virsuniu masyvas 
        boolean visited[] = new boolean[V]; 
  
        //paieska gilyn rekursiskai 
        searchRecursive(v, visited, v);
        for (int i=1; i<V;i++)
        {
            if (visited[i]==false)
            {
                searchRecursive(i, visited, i);
            }
        }
    }  
    public static void main(String args[]) 
    { 
        Graph g = new Graph(9);
        g.addEdge(1, 2);
//        g.addEdge(1, 7);
//        g.addEdge(2, 3);
//        g.addEdge(2, 5);
//        g.addEdge(3, 4);
//        g.addEdge(3, 6);
//        g.addEdge(4, 8);
//        g.addEdge(7, 5);
//        g.addEdge(5, 6);
//        g.addEdge(6, 8);
//        g.addEdge(7, 8);
        g.search(1);
        g.consoleOutput();
    } 
} 