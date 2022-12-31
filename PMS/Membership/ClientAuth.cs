namespace Membership;
public static class ClientAuth{
    public static bool Validate(string email,string password){
        bool status=true;
        if(email== "ashwini24palve@gmail.com" && password=="12345"){
            status=false;

        }
    else{
        return status=true;
    }
    return status;
    }
    public static bool Register(string firstName, string lastName,  string email, string contactNumber,string password){
         bool status=false;
          try{
            Client client=new Client();
             client.firstName=firstName;
            client.lastName=lastName;
            client.email=email;
            client.contactNumber=contactNumber;
             client.password=password;
        
     status=true;
          }
          
          catch(Exception e){
            // Exception handling Code
            

          }
          finally{
          }
         return status;
    }
}


