import { EkartPage } from './app.po';

describe('ekart App', () => {
  let page: EkartPage;

  beforeEach(() => {
    page = new EkartPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
