using Credential.AbstractFactory.Factories;

var aUnivercityFactory = new AUnivercityFactory();
var bUnivercityFactory = new BUnivercityFactory();

var aCourse = aUnivercityFactory.CreateCourse("A Course");
var aPofessor = aUnivercityFactory.CreateProfessor("A Professor");

var bCourse = bUnivercityFactory.CreateCourse("B Course");
var bPofessor = bUnivercityFactory.CreateProfessor("B Professor");
var virtualClassroom = bUnivercityFactory.CreateVirtualClassroom("B Virtual Classroom");

