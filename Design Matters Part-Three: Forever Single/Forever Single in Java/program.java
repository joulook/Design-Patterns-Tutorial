public class program{
	public static void main(String []args){
		ADABAS admin = ADABAS.getAdmin("joulook","94");
		System.out.println(admin.gerName());
		System.out.println(admin.getRecord());
	}
}