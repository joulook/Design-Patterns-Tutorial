public class ADABAS {
	private static ADABAS admin;
	private Stirng name;
	Private int record;

	private ADABAS(){
	}
	
	private ADABAS(String name, int record){
		this.name = name;
		this.record = record;
	}

	public String getName(){
		return this.name;
	}

	public int getRecord(){
		return this.record;
	}

	public static synchronized ADABAS getAdmin(String Name, int record){
		if(this.admin == null)
			admin = new Adabas(Name,record);
		return this.admin;
	}
}