module SpeclightConverter{
	
	export function convert(text:string):string{

		return parse(text).render();
	}

	function parse(text:string):Spec{
		var spec = new Spec();

      	text.trim().split(/\r?\n/).forEach(line => {
            spec.readLine(line.trim());
        });

        return spec;
	}

    function camelCase(s) {
        return s.replace(/ *\b./g,  s=>s.toUpperCase().trim());
    }

	class Spec{
		description : string[] = [];
		steps: Step[] = [];
		
		readLine(line:string){
			var stepMatch = /^(given|when|then|and)(.+)/i.exec(line);
            if (stepMatch) {
                this.steps.push(new Step(stepMatch[1], stepMatch[2].trim()));
            } else {
                this.description.push(line);
            }
		}

		render(){
			var d = this.description.join("\n");
			var s = this.steps.map(v=>v.render()).join("\n");

			return `new Spec(@"${d}")
${s}
    .Execute();`;
		}
	}

	class Step{
		methodName:string; 
		parameters:Parameter[] = [];
		tags:string[] = [];

		constructor(public block:string, public stepText:string){
			var s = this.stepText;

			//ignore apostrophes ("Isn't"):
	        s = s.replace("'", "");

	        //pull out anything that looks like a parameter:
	        s = s.replace(/`([^`]+)`|("[^"]*")|\$([^ ]+)/g, (p, g1, g2, g3) => {
	            this.parameters.push(new Parameter(g1 || g2 || g3));
	            return "_";
	        });
	      
	        //pull out anything that looks like a tag:
	        s = s.replace(/@(\S+)/g, (p, t) => {
	            this.tags.push(t);
	            return "";
	        });

	        this.methodName = camelCase(s);
		}

		render(){
			var p = this.parameters.map(v=>`, ${v.text}`).join("");
			var t = this.tags.map(v=>`.Tag("${v}")`).join("");
			return `    .${camelCase(this.block)}(${this.methodName}${p})${t}`;
		}
	}

	class Parameter{
		constructor(public text:string){

		}
	}
}