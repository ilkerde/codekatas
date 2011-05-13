var Replacer = {
  replace: function(template) {
    var text = template;
    for (key in this.placeholders) {
      var placeholder = this.getPlaceholder(key);

      while (text.indexOf(placeholder) > -1)
        text = text.replace(placeholder, this.placeholders[key]);
    }

    return text;
  },

  getPlaceholder: function(key) {
    return "$" + key + "$";
  },

  placeholders: {}
};
