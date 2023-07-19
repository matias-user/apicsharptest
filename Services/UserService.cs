using models;

public class UserService{
    public string Login(){
        User user = new User();
        if( user.NameUser == "admin" && user.Password == "123" ){

            return "Sesión iniciada";
        }
        return "Login incorrecto";
        

    }
}