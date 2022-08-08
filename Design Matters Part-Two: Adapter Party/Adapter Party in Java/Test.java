class Test {
        
	public static void Main(string[] args) {

            PGPClass pgpObject = new PGPClass();
            pgpObject.setName("JouLook MHMV");
            PGP1TOPGP2Adapter adapter = new PGP1TOPGP2Adapter(pgpObject);
            System.out.println("Customer first name: " + adapter.getFirstName());
            System.out.println("Customer last name: " + adapter.getLastName());
        }
    }