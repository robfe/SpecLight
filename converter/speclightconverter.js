var SpeclightConverter;
(function (SpeclightConverter) {
    function convert(text) {
        return parse(text).render();
    }
    SpeclightConverter.convert = convert;
    function parse(text) {
        var spec = new Spec();
        text.trim().split(/\r?\n/).forEach(function (line) {
            spec.readLine(line.trim());
        });
        return spec;
    }
    function camelCase(s) {
        return s.replace(/ *\b./g, function (s) { return s.toUpperCase().trim(); });
    }
    var Spec = (function () {
        function Spec() {
            this.description = [];
            this.steps = [];
        }
        Spec.prototype.readLine = function (line) {
            var stepMatch = /^(given|when|then|and)(.+)/i.exec(line);
            if (stepMatch) {
                this.steps.push(new Step(stepMatch[1], stepMatch[2].trim()));
            }
            else {
                this.description.push(line);
            }
        };
        Spec.prototype.render = function () {
            var d = this.description.join("\n");
            var s = this.steps.map(function (v) { return v.render(); }).join("\n");
            return "new Spec(@\"" + d + "\")\n" + s + "\n    .Execute();";
        };
        return Spec;
    })();
    var Step = (function () {
        function Step(block, stepText) {
            var _this = this;
            this.block = block;
            this.stepText = stepText;
            this.parameters = [];
            this.tags = [];
            var s = this.stepText;
            //ignore apostrophes ("Isn't"):
            s = s.replace("'", "");
            //pull out anything that looks like a parameter:
            s = s.replace(/`([^`]+)`|("[^"]*")|\$([^ ]+)/g, function (p, g1, g2, g3) {
                _this.parameters.push(new Parameter(g1 || g2 || g3));
                return "_";
            });
            //pull out anything that looks like a tag:
            s = s.replace(/@(\S+)/g, function (p, t) {
                _this.tags.push(t);
                return "";
            });
            this.methodName = camelCase(s);
        }
        Step.prototype.render = function () {
            var p = this.parameters.map(function (v) { return (", " + v.text); }).join("");
            var t = this.tags.map(function (v) { return (".Tag(\"" + v + "\")"); }).join("");
            return "    ." + camelCase(this.block) + "(" + this.methodName + p + ")" + t;
        };
        return Step;
    })();
    var Parameter = (function () {
        function Parameter(text) {
            this.text = text;
        }
        return Parameter;
    })();
})(SpeclightConverter || (SpeclightConverter = {}));
