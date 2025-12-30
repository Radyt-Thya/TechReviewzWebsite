// helper to get a fresh antiforgery token from server
async function getAntiforgeryToken() {
    try {
        const resp = await fetch('/antiforgery/token', { credentials: 'same-origin' });
        if (!resp.ok) return null;
        const json = await resp.json();
        return json?.token ?? null;
    } catch (ex) {
        console.error('token fetch error', ex);
        return null;
    }
}

window.followUser = async function (targetUsername, btn) {
    if (!targetUsername) return;
    try {
        btn && (btn.disabled = true);
        const token = await getAntiforgeryToken();
        const headers = { 'Content-Type': 'application/json' };
        if (token) headers['RequestVerificationToken'] = token;
        const resp = await fetch('/api/follow', {
            method: 'POST',
            credentials: 'same-origin',
            headers,
            body: JSON.stringify({ targetUsername })
        });
        const data = await resp.json();
        if (resp.ok && data?.success) {
            location.reload();
            return;
        }
        alert(data?.error ?? 'Unable to follow user');
    } catch (ex) {
        console.error('follow error', ex);
        alert('Error following user: ' + (ex?.message ?? ex));
    } finally {
        btn && (btn.disabled = false);
    }
};

window.unfollowUser = async function (targetUsername, btn) {
    if (!targetUsername) return;
    try {
        btn && (btn.disabled = true);
        const token = await getAntiforgeryToken();
        const headers = { 'Content-Type': 'application/json' };
        if (token) headers['RequestVerificationToken'] = token;
        const resp = await fetch('/api/unfollow', {
            method: 'POST',
            credentials: 'same-origin',
            headers,
            body: JSON.stringify({ targetUsername })
        });
        const data = await resp.json();
        if (resp.ok && data?.success) {
            location.reload();
            return;
        }
        alert(data?.error ?? 'Unable to unfollow user');
    } catch (ex) {
        console.error('unfollow error', ex);
        alert('Error unfollowing user: ' + (ex?.message ?? ex));
    } finally {
        btn && (btn.disabled = false);
    }
};