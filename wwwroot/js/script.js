document.addEventListener('DOMContentLoaded', () => {
  if (document.querySelector('.typing-name')) {
    new Typed('.typing-name', {
      strings: ['Isabella Nicole!', 'Isel!', 'Nics!'],
      typeSpeed: 90,
      backSpeed: 50,
      showCursor: true,
      cursorChar: '|',
      loop: false
    });
  }

  if (document.querySelector('.multiple-text')) {
    new Typed('.multiple-text', {
      strings: [
        'a Computer Science Student',
        'an Aspiring Full-Stack Developer'
      ],
      typeSpeed: 70,
      backSpeed: 40,
      backDelay: 1500,
      loop: true
    });
  }

  const navLinks = document.querySelectorAll('.nav-item');
  const sections = document.querySelectorAll('.section');
  const navTriggers = document.querySelectorAll('.nav-trigger');
  const menuIcon = document.querySelector('#menu-icon');
  const navLinksContainer = document.querySelector('.nav-links');

  if (menuIcon && navLinksContainer) {
    menuIcon.addEventListener('click', () => {
      navLinksContainer.classList.toggle('active');
      menuIcon.classList.toggle('fa-xmark');
    });
  }

  function switchSection(targetId) {
    if (navLinksContainer) {
      navLinksContainer.classList.remove('active');
      if (menuIcon) menuIcon.classList.remove('fa-xmark');
    }

    navLinks.forEach(link => {
      link.classList.remove('active');
      if (link.getAttribute('href') === `#${targetId}`) {
        link.classList.add('active');
      }
    });

    sections.forEach(sec => {
      sec.classList.remove('active');
    });

    const targetSection = document.getElementById(targetId);
    if (targetSection) {
      targetSection.classList.add('active');
      window.scrollTo({ top: 0, behavior: 'smooth' });
    }
  }

  navLinks.forEach(link => {
    link.addEventListener('click', (e) => {
      e.preventDefault();
      const targetId = link.getAttribute('href').substring(1);
      switchSection(targetId);
    });
  });

  navTriggers.forEach(btn => {
    btn.addEventListener('click', (e) => {
      e.preventDefault();
      const targetId = btn.getAttribute('href').substring(1);
      switchSection(targetId);
    });
  });
});