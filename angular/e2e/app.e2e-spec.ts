import { Clase7TemplatePage } from './app.po';

describe('Clase7 App', function() {
  let page: Clase7TemplatePage;

  beforeEach(() => {
    page = new Clase7TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
