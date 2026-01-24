// Mobile menu
const btn = document.getElementById('menuBtn');
const links = document.getElementById('navLinks');
btn?.addEventListener('click', () => {
    const open = links.classList.toggle('open');
    btn.setAttribute('aria-expanded', String(open));
});

// Footer year
document.getElementById('year').textContent = new Date().getFullYear();

// Simple "mailto" submit (replace email below)
function sendMessage(e){
    e.preventDefault();
    const data = new FormData(e.target);
    const name = encodeURIComponent(data.get('name') || '');
    const phone = encodeURIComponent(data.get('phone') || '');
    const email = encodeURIComponent(data.get('email') || '');
    const msg = encodeURIComponent(data.get('message') || '');
    const body = `Name: ${name}%0D%0APhone: ${phone}%0D%0AEmail: ${email}%0D%0A%0D%0AProject:%0D%0A${msg}`;
    const to = "jccadaz@gmail.com"; // <-- change this
    window.location.href = `mailto:${to}?subject=New consultation request&body=${body}`;
    return false;
}