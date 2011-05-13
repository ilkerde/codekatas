var Replacer = {
  replace: function(template) {
    var text = template;
    for (key in this.placeholders) {
      while (text.indexOf("$" + key + "$") > -1)
        text = text.replace("$" + key + "$", this.placeholders[key]);
    }

    return text;
  },

  placeholders: {}
};
