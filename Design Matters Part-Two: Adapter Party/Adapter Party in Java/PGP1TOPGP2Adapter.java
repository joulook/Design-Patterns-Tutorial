public class PGP1TOPGP2Adapter Implement PGP2Interface {

	public PGPClass pgpObject;
	public String fname;
	public String lname;
	
	public PGP1TOPGP2Adapter(PGPClass pgpObject)
	{
		this.pgpObject = pgpObject;
		fname = pgpObject.getName().Split(' ')[0];
            	lname = pgpObject.getName().Split(' ')[1];
	}
	
	public string getFirstName()
        {
            return this.fname;
        }

        public string getLastName()
        {
            this.return lname;
        }

        public void setFirstName(string fname)
        {
            this.fname = fname;
        }

        public void setLastName(string lname)
        {
            this.lname = lname;
        }
	
}