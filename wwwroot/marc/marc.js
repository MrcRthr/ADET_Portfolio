(() => {
  const root = document.documentElement;
  const hero = document.querySelector("[data-marc-hero]");
  const card = hero?.querySelector(".marc-card");

  // Progress bar + hero card straightening as you scroll
  let ticking = false;
  const onScroll = () => {
    if (ticking) return;
    ticking = true;
    requestAnimationFrame(() => {
      const max = root.scrollHeight - innerHeight;
      root.style.setProperty("--marc-scroll", max > 0 ? (scrollY / max).toFixed(3) : 0);

      if (hero && card) {
        const p = Math.min(Math.max(scrollY / (hero.offsetHeight * 0.6), 0), 1);
        hero.style.setProperty("--p", p.toFixed(3));
        card.style.setProperty("--p", p.toFixed(3));
      }
      ticking = false;
    });
  };
  addEventListener("scroll", onScroll, { passive: true });
  onScroll();

  // Sections fade up once they enter the screen
  const revealer = new IntersectionObserver((entries) => {
    for (const entry of entries) {
      if (entry.isIntersecting) {
        entry.target.classList.add("is-visible");
        revealer.unobserve(entry.target);
      }
    }
  }, { threshold: 0.15 });
  document.querySelectorAll(".marc-reveal").forEach((el) => revealer.observe(el));
})();
