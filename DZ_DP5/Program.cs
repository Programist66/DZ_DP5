using DZ_DP5;

Stub stub = new Stub(new CaptchaHandler(new CookiesHandler(new RegisterHandler(new BannerHandler(null)))), new Movie());
stub.Play();
