var Replacer = {
  replace: function(template) {
    var text = template;
    for (key in this.placeholders) {
      text = text.replace("$" + key + "$", this.placeholders[key]);
    }

    return text;
  },

  placeholders: {}
};
