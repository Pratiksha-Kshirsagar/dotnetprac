namespace BLL;
using BOL;
using connection;

public class Studentdata {

    public List<Student> getAll() {
        List<Student> stlist = DBmanager.getAll(); 
        
        return stlist;
    }

      public void insert(string fname,string lname) {
        DBmanager.insert(fname,lname); 
        
        
    }
}